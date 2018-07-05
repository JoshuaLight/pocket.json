﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Pocket.Json.Tests
{
    public class JsonTest
    {
        public class Empty : IEquatable<Empty>
        {
            public bool Equals(Empty other) => true;
        }
        
        public class IntAndInt : IEquatable<IntAndInt>
        {
            public int Item1;
            public int Item2;

            public bool Equals(IntAndInt other) => Item1 == other.Item1 && Item2 == other.Item2;
        }

        public class IntAndString : IEquatable<IntAndString>
        {
            public int Item1;
            public string Item2;

            public bool Equals(IntAndString other) => Item1 == other.Item1 && Item2 == other.Item2;
        }

        public class IntAndAnotherIntAndInt : IEquatable<IntAndAnotherIntAndInt>
        {
            public int Item1;
            public IntAndInt Item2;

            public bool Equals(IntAndAnotherIntAndInt other) =>
                Item1 == other.Item1 && (Item2?.Equals(other.Item2) ?? false);
        }

        public class IntArray : IEquatable<IntArray>
        {
            public int[] Items;

            public bool Equals(IntArray other) => Items.SequenceEqual(other.Items);
        }

        public class UnderscoredInt : IEquatable<UnderscoredInt>
        {
            public int Item_1;

            public bool Equals(UnderscoredInt other) => other != null && Item_1 == other.Item_1;
        }
        
        public class UnderscoredEmptyAndEmpty : IEquatable<UnderscoredEmptyAndEmpty>
        {            
            public Empty Item_1;
            public Empty Item_2;

            public bool Equals(UnderscoredEmptyAndEmpty other) =>
                other != null && Item_1.Equals(other.Item_1) && Item_2.Equals(other.Item_2);
        }

        public class UnderscoredNestedEmptyAndEmpty : IEquatable<UnderscoredNestedEmptyAndEmpty>
        {
            public class Nested : IEquatable<Nested>
            {
                public UnderscoredEmptyAndEmpty Item1;

                public bool Equals(Nested other) => Item1.Equals(other.Item1);
            }

            public Nested Item1;

            public bool Equals(UnderscoredNestedEmptyAndEmpty other) => Item1.Equals(other.Item1);
        }
        
        public class StrangeNestedWithUnderscore : IEquatable<StrangeNestedWithUnderscore>
        {
            public class Nested1 : IEquatable<Nested1>
            {
                public Nested2 Item1;

                public bool Equals(Nested1 other) => Item1.Equals(other.Item1);
            }
            
            public class Nested2 : IEquatable<Nested2>
            {
                // These fields have hashcode collision problem.
                public Nested3 Item_1;
                public Nested4 Item_2;

                public bool Equals(Nested2 other) =>
                    Item_1.Equals(other.Item_1) && Item_2.Equals(other.Item_2);
            }

            public class Nested3 : IEquatable<Nested3>
            {
                public Nested4 Item1;

                public bool Equals(Nested3 other) => Item1.Equals(other.Item1);
            }
            
            public class Nested4 : IEquatable<Nested4>
            {
                public bool Equals(Nested4 other) => true;
            }

            public Nested1 Item1;

            public bool Equals(StrangeNestedWithUnderscore other) => Item1.Equals(other.Item1);
        }
        
        #region Appends
        
        protected static AppendsFluent<T> Appends<T>(T instance) => new AppendsFluent<T>(instance);

        protected struct AppendsFluent<T>
        {
            private readonly T _instance;

            public AppendsFluent(T instance)
            {
                _instance = instance;
            }

            public void As(string json) => Assert.Equal(json, _instance.AsJson());
        }

        #endregion
        
        #region Unwraps
        
        protected static UnwrapsFluent Unwraps(string json)
        {
            return new UnwrapsFluent(json);
        }

        protected struct UnwrapsFluent
        {
            private readonly string _json;

            public UnwrapsFluent(string json)
            {
                _json = json;
            }
            
            public void As<T>(T value)
            {
                var type = typeof(T);
                if (type.IsGeneric(typeof(IEnumerable<>)) || type.GetTypeInfo().ImplementedInterfaces.Any(x => x.IsGeneric(typeof(IEnumerable<>))))
                    Assert.Equal((IEnumerable) value, (IEnumerable) _json.AsJson<T>());
                else
                    Assert.Equal(value, _json.AsJson<T>());
            }

            public void As(int value)
            {
                Assert.Equal(value, _json.AsJson<int>());
                Assert.Equal(-value, ("-" + _json).AsJson<int>());
            }

            public void As(long value)
            {
                Assert.Equal(value, _json.AsJson<long>());
                Assert.Equal(-value, ("-" + _json).AsJson<long>());
            }
        }
        
        #endregion
    }
}