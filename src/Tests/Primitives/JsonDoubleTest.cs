﻿using Xunit;

namespace Pocket.Json.Tests.Primitives
{
    public class JsonDoubleTest : JsonTest
    {
        [Fact]
        public void Write_ShouldWorkCorrectly()
        {
            Writes(0.0).As("0");
            Writes(0.1).As("0.1");
            Writes(0.01).As("0.01");
            Writes(0.001).As("0.001");
            Writes(0.0001).As("0.0001");
            Writes(0.00001).As("0.00001");
            Writes(0.000001).As("0.000001");
            Writes(0.0000001).As("0.0000001");
            Writes(0.00000001).As("0.00000001");
            Writes(0.000000001).As("0.000000001");
            Writes(0.0000000001).As("0.0000000001");
            Writes(0.00000000001).As("0.00000000001");
            Writes(0.000000000001).As("0.000000000001");
            Writes(0.0000000000001).As("0.0000000000001");
            Writes(0.0000000000001).As("0.0000000000001");
            Writes(0.00000000000001).As("0.00000000000001");
            Writes(0.0000000000000001).As("0");

            Writes(1.1).As("1.1");
            Writes(1.12).As("1.12");
            Writes(1.123).As("1.123");
            Writes(1.1234).As("1.1234");
            Writes(1.12345).As("1.12345");
            Writes(1.123456).As("1.123456");
            Writes(1.1234567).As("1.1234567");
            Writes(1.12345678).As("1.12345678");
            Writes(1.123456789).As("1.123456789");
            Writes(1.1234567891).As("1.1234567891");
            Writes(1.12345678912).As("1.12345678912");
            Writes(1.123456789123).As("1.123456789123");
            Writes(1.1234567891234).As("1.1234567891234");
            Writes(1.12345678912345).As("1.12345678912345");
            Writes(1.123456789123456).As("1.12345678912346");
            Writes(1.1234567891234567).As("1.12345678912346");
            Writes(1.12345678912345678).As("1.12345678912346");
            Writes(1.123456789123456789).As("1.12345678912346");
            Writes(1.1234567891234567891).As("1.12345678912346");
            Writes(1.12345678912345678912).As("1.12345678912346");
            Writes(1.123456789123456789123).As("1.12345678912346");

            Writes(11.1).As("11.1");
            Writes(11.12).As("11.12");
            Writes(11.123).As("11.123");
            Writes(11.1234).As("11.1234");
            Writes(11.12345).As("11.12345");
            Writes(11.123456).As("11.123456");
            Writes(11.1234567).As("11.1234567");
            Writes(11.12345678).As("11.12345678");
            Writes(11.123456789).As("11.123456789");
            Writes(11.1234567891).As("11.1234567891");
            Writes(11.12345678912).As("11.12345678912");
            Writes(11.123456789123).As("11.123456789123");
            Writes(11.1234567891234).As("11.1234567891234");
            Writes(11.12345678912345).As("11.1234567891235");
            Writes(11.123456789123456).As("11.1234567891235");
            Writes(11.1234567891234567).As("11.1234567891235");
            Writes(11.12345678912345678).As("11.1234567891235");
            Writes(11.123456789123456789).As("11.1234567891235");
            Writes(11.1234567891234567891).As("11.1234567891235");
            Writes(11.12345678912345678912).As("11.1234567891235");
            Writes(11.123456789123456789123).As("11.1234567891235");

            Writes(111.1).As("111.1");
            Writes(111.12).As("111.12");
            Writes(111.123).As("111.123");
            Writes(111.1234).As("111.1234");
            Writes(111.12345).As("111.12345");
            Writes(111.123456).As("111.123456");
            Writes(111.1234567).As("111.1234567");
            Writes(111.12345678).As("111.12345678");
            Writes(111.123456789).As("111.123456789");
            Writes(111.1234567891).As("111.1234567891");
            Writes(111.12345678912).As("111.12345678912");
            Writes(111.123456789123).As("111.123456789123");
            Writes(111.1234567891234).As("111.123456789123");
            Writes(111.12345678912345).As("111.123456789123");
            Writes(111.123456789123456).As("111.123456789123");
            Writes(111.1234567891234567).As("111.123456789123");
            Writes(111.12345678912345678).As("111.123456789123");

            Writes(1111.1).As("1111.1");
            Writes(1111.12).As("1111.12");
            Writes(1111.123).As("1111.123");
            Writes(1111.1234).As("1111.1234");
            Writes(1111.12345).As("1111.12345");
            Writes(1111.123456).As("1111.123456");
            Writes(1111.1234567).As("1111.1234567");
            Writes(1111.12345678).As("1111.12345678");
            Writes(1111.123456789).As("1111.123456789");
            Writes(1111.1234567891).As("1111.1234567891");
            Writes(1111.12345678912).As("1111.12345678912");
            Writes(1111.123456789123).As("1111.12345678912");
            Writes(1111.1234567891234).As("1111.12345678912");
            Writes(1111.12345678912345).As("1111.12345678912");
            Writes(1111.123456789123456).As("1111.12345678912");
            Writes(1111.1234567891234567).As("1111.12345678912");

            Writes(11111.1).As("11111.1");
            Writes(11111.12).As("11111.12");
            Writes(11111.123).As("11111.123");
            Writes(11111.1234).As("11111.1234");
            Writes(11111.12345).As("11111.12345");
            Writes(11111.123456).As("11111.123456");
            Writes(11111.1234567).As("11111.1234567");
            Writes(11111.12345678).As("11111.12345678");
            Writes(11111.123456789).As("11111.123456789");
            Writes(11111.1234567891).As("11111.1234567891");
            Writes(11111.12345678912).As("11111.1234567891");
            Writes(11111.123456789123).As("11111.1234567891");
            Writes(11111.1234567891234).As("11111.1234567891");
            Writes(11111.12345678912345).As("11111.1234567891");
            Writes(11111.123456789123456).As("11111.1234567891");

            Writes(111111.1).As("111111.1");
            Writes(111111.12).As("111111.12");
            Writes(111111.123).As("111111.123");
            Writes(111111.1234).As("111111.1234");
            Writes(111111.12345).As("111111.12345");
            Writes(111111.123456).As("111111.123456");
            Writes(111111.1234567).As("111111.1234567");
            Writes(111111.12345678).As("111111.12345678");
            Writes(111111.123456789).As("111111.123456789");
            Writes(111111.1234567891).As("111111.123456789");
            Writes(111111.12345678912).As("111111.123456789");
            Writes(111111.123456789123).As("111111.123456789");
            Writes(111111.1234567891234).As("111111.123456789");
            Writes(111111.12345678912345).As("111111.123456789");

            Writes(1111111.0).As("1111111");
            Writes(1111111.1).As("1111111.1");
            Writes(1111111.12).As("1111111.12");
            Writes(1111111.123).As("1111111.123");
            Writes(1111111.1234).As("1111111.1234");
            Writes(1111111.12345).As("1111111.12345");
            Writes(1111111.123456).As("1111111.123456");
            Writes(1111111.1234567).As("1111111.1234567");
            Writes(1111111.12345678).As("1111111.12345678");
            Writes(1111111.123456789).As("1111111.12345679");
            Writes(1111111.1234567891).As("1111111.12345679");
            Writes(1111111.12345678912).As("1111111.12345679");
            Writes(1111111.123456789123).As("1111111.12345679");
            Writes(1111111.1234567891234).As("1111111.12345679");

            Writes(11111111.0).As("11111111");
            Writes(11111111.1).As("11111111.1");
            Writes(11111111.12).As("11111111.12");
            Writes(11111111.123).As("11111111.123");
            Writes(11111111.1234).As("11111111.1234");
            Writes(11111111.12345).As("11111111.12345");
            Writes(11111111.123456).As("11111111.123456");
            Writes(11111111.1234567).As("11111111.1234567");
            Writes(11111111.12345678).As("11111111.1234568");
            Writes(11111111.123456789).As("11111111.1234568");
            Writes(11111111.1234567891).As("11111111.1234568");
            Writes(11111111.12345678912).As("11111111.1234568");
            Writes(11111111.123456789123).As("11111111.1234568");

            Writes(111111111.0).As("111111111");
            Writes(111111111.1).As("111111111.1");
            Writes(111111111.12).As("111111111.12");
            Writes(111111111.123).As("111111111.123");
            Writes(111111111.1234).As("111111111.1234");
            Writes(111111111.12345).As("111111111.12345");
            Writes(111111111.123456).As("111111111.123456");
            Writes(111111111.1234567).As("111111111.123457");
            Writes(111111111.12345678).As("111111111.123457");
            Writes(111111111.123456789).As("111111111.123457");
            Writes(111111111.1234567891).As("111111111.123457");
            Writes(111111111.12345678912).As("111111111.123457");

            Writes(1111111111.0).As("1111111111");
            Writes(1111111111.1).As("1111111111.1");
            Writes(1111111111.12).As("1111111111.12");
            Writes(1111111111.123).As("1111111111.123");
            Writes(1111111111.1234).As("1111111111.1234");
            Writes(1111111111.12345).As("1111111111.12345");
            Writes(1111111111.123456).As("1111111111.12346");
            Writes(1111111111.1234567).As("1111111111.12346");
            Writes(1111111111.12345678).As("1111111111.12346");
            Writes(1111111111.123456789).As("1111111111.12346");
            Writes(1111111111.1234567891).As("1111111111.12346");

            Writes(11111111111.0).As("11111111111");
            Writes(11111111111.1).As("11111111111.1");
            Writes(11111111111.12).As("11111111111.12");
            Writes(11111111111.123).As("11111111111.123");
            Writes(11111111111.1234).As("11111111111.1234");
            Writes(11111111111.12345).As("11111111111.1234");
            Writes(11111111111.123456).As("11111111111.1235");
            Writes(11111111111.1234567).As("11111111111.1235");
            Writes(11111111111.12345678).As("11111111111.1235");
            Writes(11111111111.123456789).As("11111111111.1235");

            Writes(111111111111.0).As("111111111111");
            Writes(111111111111.1).As("111111111111.1");
            Writes(111111111111.12).As("111111111111.12");
            Writes(111111111111.123).As("111111111111.123");
            Writes(111111111111.1234).As("111111111111.123");
            Writes(111111111111.12345).As("111111111111.123");
            Writes(111111111111.123456).As("111111111111.123");
            Writes(111111111111.1234567).As("111111111111.123");
            Writes(111111111111.12345678).As("111111111111.123");

            Writes(1111111111111.0).As("1111111111111");
            Writes(1111111111111.1).As("1111111111111.1");
            Writes(1111111111111.12).As("1111111111111.12");
            Writes(1111111111111.123).As("1111111111111.12");
            Writes(1111111111111.1234).As("1111111111111.12");
            Writes(1111111111111.12345).As("1111111111111.12");
            Writes(1111111111111.123456).As("1111111111111.12");
            Writes(1111111111111.1234567).As("1111111111111.12");

            Writes(11111111111111.0).As("11111111111111");
            Writes(11111111111111.1).As("11111111111111.1");
            Writes(11111111111111.12).As("11111111111111.1");
            Writes(11111111111111.123).As("11111111111111.1");
            Writes(11111111111111.1234).As("11111111111111.1");
            Writes(11111111111111.12345).As("11111111111111.1");
            Writes(11111111111111.123456).As("11111111111111.1");

            Writes(111111111111111.0).As("111111111111111");
            Writes(111111111111111.1).As("111111111111111");
            Writes(111111111111111.12).As("111111111111111");
            Writes(111111111111111.123).As("111111111111111");
            Writes(111111111111111.1234).As("111111111111111");
            Writes(111111111111111.12345).As("111111111111111");

            Writes(1111111111111111.0).As("111111111111111E1");
            Writes(1111111111111111.1).As("111111111111111E1");
            Writes(1111111111111111.12).As("111111111111111E1");
            Writes(1111111111111111.123).As("111111111111111E1");
            Writes(1111111111111111.1234).As("111111111111111E1");

            Writes(11111111111111111.0).As("111111111111111E2");
            Writes(11111111111111111.1).As("111111111111111E2");
            Writes(11111111111111111.12).As("111111111111111E2");
            Writes(11111111111111111.123).As("111111111111111E2");

            Writes(111111111111111111.0).As("111111111111111E3");
            Writes(111111111111111111.1).As("111111111111111E3");
            Writes(111111111111111111.12).As("111111111111111E3");

            Writes(1111111111111111111.0).As("111111111111111E4");
            Writes(1111111111111111111.1).As("111111111111111E4");

            Writes(11111111111111111111.0).As("111111111111111E5");
            Writes(111111111111111111111.0).As("111111111111111E6");
            Writes(1111111111111111111111.0).As("111111111111111E7");
            Writes(11111111111111111111111.0).As("111111111111111E8");
            Writes(111111111111111111111111.0).As("111111111111111E9");
            Writes(1111111111111111111111111.0).As("111111111111111E10");
            Writes(11111111111111111111111111.0).As("111111111111111E11");
            Writes(111111111111111111111111111.0).As("111111111111111E12");
            Writes(1111111111111111111111111111.0).As("111111111111111E13");
            Writes(11111111111111111111111111111.0).As("111111111111111E14");
            Writes(111111111111111111111111111111.0).As("111111111111111E15");
            Writes(1111111111111111111111111111111.0).As("111111111111111E16");

            Writes(0).As("0");
            Writes(0.1).As("0.1");
            Writes(0.02).As("0.02");
            Writes(0.102).As("0.102");
            Writes(0.1002).As("0.1002");
            Writes(0.10203).As("0.10203");
            Writes(0.102034).As("0.102034");
            Writes(0.1020341).As("0.1020341");
            Writes(0.10203411).As("0.10203411");
            Writes(0.102034111).As("0.102034111");
            Writes(0.1020341101).As("0.1020341101");
            Writes(0.10203411001).As("0.10203411001");
            Writes(0.102034110001).As("0.102034110001");
            Writes(0.1020341100001).As("0.1020341100001");
            Writes(0.10203411000001).As("0.10203411000001");
            Writes(0.102034110000001).As("0.102034110000001");
            Writes(0.1020341100000001).As("0.10203411");

            Writes(0.523154234575693).As("0.523154234575693");
        }

        [Fact]
        public void Read_ShouldWorkCorrectly()
        {
            Reads("0").As(0.0);
            Reads("0.1").As(0.1);
            Reads("0.01").As(0.01);
            Reads("0.001").As(0.001);
            Reads("0.0001").As(0.0001);
            Reads("0.00001").As(0.00001);
            Reads("0.000001").As(0.000001);
            Reads("0.0000001").As(0.0000001);
            Reads("0.00000001").As(0.00000001);
            Reads("0.000000001").As(0.000000001);
            Reads("0.0000000001").As(0.0000000001);
            Reads("0.00000000001").As(0.00000000001);
            Reads("0.000000000001").As(0.000000000001);
            Reads("0.0000000000001").As(0.0000000000001);
            Reads("0.00000000000001").As(0.00000000000001);
            Reads("0.000000000000001").As(0.0);
            Reads("0.0000000000000001").As(0.0);
            Reads("0.00000000000000001").As(0.0);
            Reads("0.000000000000000001").As(0.0);
            Reads("0.0000000000000000001").As(0.0);
            Reads("0.00000000000000000001").As(0.0);
            Reads("0.000000000000000000001").As(0.0);
            Reads("0.0000000000000000000001").As(0.0);

            Reads("1.1").As(1.1);
            Reads("1.12").As(1.12);
            Reads("1.123").As(1.123);
            Reads("1.1234").As(1.1234);
            Reads("1.12345").As(1.12345);
            Reads("1.123456").As(1.123456);
            Reads("1.1234567").As(1.1234567);
            Reads("1.12345678").As(1.12345678);
            Reads("1.123456789").As(1.123456789);
            Reads("1.1234567891").As(1.1234567891);
            Reads("1.12345678912").As(1.12345678912);
            Reads("1.123456789123").As(1.123456789123);
            Reads("1.1234567891234").As(1.1234567891234);
            Reads("1.12345678912345").As(1.12345678912345);
            Reads("1.123456789123456").As(1.12345678912345);
            Reads("1.1234567891234567").As(1.12345678912345);
            Reads("1.12345678912345678").As(1.12345678912345);
            Reads("1.123456789123456789").As(1.12345678912345);
            Reads("1.1234567891234567891").As(1.12345678912345);
            Reads("1.12345678912345678912").As(1.12345678912345);
            Reads("1.123456789123456789123").As(1.12345678912345);

            Reads("11.1").As(11.1);
            Reads("11.12").As(11.12);
            Reads("11.123").As(11.123);
            Reads("11.1234").As(11.1234);
            Reads("11.12345").As(11.12345);
            Reads("11.123456").As(11.123456);
            Reads("11.1234567").As(11.1234567);
            Reads("11.12345678").As(11.12345678);
            Reads("11.123456789").As(11.123456789);
            Reads("11.1234567891").As(11.1234567891);
            Reads("11.12345678912").As(11.12345678912);
            Reads("11.123456789123").As(11.123456789123);
            Reads("11.1234567891234").As(11.1234567891234);
            Reads("11.12345678912345").As(11.1234567891234);
            Reads("11.123456789123456").As(11.1234567891234);
            Reads("11.1234567891234567").As(11.1234567891234);
            Reads("11.12345678912345678").As(11.1234567891234);
            Reads("11.123456789123456789").As(11.1234567891234);
            Reads("11.1234567891234567891").As(11.1234567891234);
            Reads("11.12345678912345678912").As(11.1234567891234);
            Reads("11.123456789123456789123").As(11.1234567891234);

            Reads("111.1").As(111.1);
            Reads("111.12").As(111.12);
            Reads("111.123").As(111.123);
            Reads("111.1234").As(111.1234);
            Reads("111.12345").As(111.12345);
            Reads("111.123456").As(111.123456);
            Reads("111.1234567").As(111.1234567);
            Reads("111.12345678").As(111.12345678);
            Reads("111.123456789").As(111.123456789);
            Reads("111.1234567891").As(111.1234567891);
            Reads("111.12345678912").As(111.12345678912);
            Reads("111.123456789123").As(111.123456789123);
            Reads("111.1234567891234").As(111.123456789123);
            Reads("111.12345678912345").As(111.123456789123);
            Reads("111.123456789123456").As(111.123456789123);
            Reads("111.1234567891234567").As(111.123456789123);
            Reads("111.12345678912345678").As(111.123456789123);

            Reads("1111.1").As(1111.1);
            Reads("1111.12").As(1111.12);
            Reads("1111.123").As(1111.123);
            Reads("1111.1234").As(1111.1234);
            Reads("1111.12345").As(1111.12345);
            Reads("1111.123456").As(1111.123456);
            Reads("1111.1234567").As(1111.1234567);
            Reads("1111.12345678").As(1111.12345678);
            Reads("1111.123456789").As(1111.123456789);
            Reads("1111.1234567891").As(1111.1234567891);
            Reads("1111.12345678912").As(1111.12345678912);
            Reads("1111.123456789123").As(1111.12345678912);
            Reads("1111.1234567891234").As(1111.12345678912);
            Reads("1111.12345678912345").As(1111.12345678912);
            Reads("1111.123456789123456").As(1111.12345678912);
            Reads("1111.1234567891234567").As(1111.12345678912);

            Reads("11111.1").As(11111.1);
            Reads("11111.12").As(11111.12);
            Reads("11111.123").As(11111.123);
            Reads("11111.1234").As(11111.1234);
            Reads("11111.12345").As(11111.12345);
            Reads("11111.123456").As(11111.123456);
            Reads("11111.1234567").As(11111.1234567);
            Reads("11111.12345678").As(11111.12345678);
            Reads("11111.123456789").As(11111.123456789);
            Reads("11111.1234567891").As(11111.1234567891);
            Reads("11111.12345678912").As(11111.1234567891);
            Reads("11111.123456789123").As(11111.1234567891);
            Reads("11111.1234567891234").As(11111.1234567891);
            Reads("11111.12345678912345").As(11111.1234567891);
            Reads("11111.123456789123456").As(11111.1234567891);

            Reads("111111.1").As(111111.1);
            Reads("111111.12").As(111111.12);
            Reads("111111.123").As(111111.123);
            Reads("111111.1234").As(111111.1234);
            Reads("111111.12345").As(111111.12345);
            Reads("111111.123456").As(111111.123456);
            Reads("111111.1234567").As(111111.1234567);
            Reads("111111.12345678").As(111111.12345678);
            Reads("111111.123456789").As(111111.123456789);
            Reads("111111.1234567891").As(111111.123456789);
            Reads("111111.12345678912").As(111111.123456789);
            Reads("111111.123456789123").As(111111.123456789);
            Reads("111111.1234567891234").As(111111.123456789);
            Reads("111111.12345678912345").As(111111.123456789);

            Reads("1111111.1").As(1111111.1);
            Reads("1111111.12").As(1111111.12);
            Reads("1111111.123").As(1111111.123);
            Reads("1111111.1234").As(1111111.1234);
            Reads("1111111.12345").As(1111111.12345);
            Reads("1111111.123456").As(1111111.123456);
            Reads("1111111.1234567").As(1111111.1234567);
            Reads("1111111.12345678").As(1111111.12345678);
            Reads("1111111.123456789").As(1111111.12345678);
            Reads("1111111.1234567891").As(1111111.12345678);
            Reads("1111111.12345678912").As(1111111.12345678);
            Reads("1111111.123456789123").As(1111111.12345678);
            Reads("1111111.1234567891234").As(1111111.12345678);

            Reads("11111111.1").As(11111111.1);
            Reads("11111111.12").As(11111111.12);
            Reads("11111111.123").As(11111111.123);
            Reads("11111111.1234").As(11111111.1234);
            Reads("11111111.12345").As(11111111.12345);
            Reads("11111111.123456").As(11111111.123456);
            Reads("11111111.1234567").As(11111111.1234567);
            Reads("11111111.12345678").As(11111111.1234567);
            Reads("11111111.123456789").As(11111111.1234567);
            Reads("11111111.1234567891").As(11111111.1234567);
            Reads("11111111.12345678912").As(11111111.1234567);
            Reads("11111111.123456789123").As(11111111.1234567);

            Reads("111111111.1").As(111111111.1);
            Reads("111111111.12").As(111111111.12);
            Reads("111111111.123").As(111111111.123);
            Reads("111111111.1234").As(111111111.1234);
            Reads("111111111.12345").As(111111111.12345);
            Reads("111111111.123456").As(111111111.123456);
            Reads("111111111.1234567").As(111111111.123456);
            Reads("111111111.12345678").As(111111111.123456);
            Reads("111111111.123456789").As(111111111.123456);
            Reads("111111111.1234567891").As(111111111.123456);
            Reads("111111111.12345678912").As(111111111.123456);

            Reads("1111111111.1").As(1111111111.1);
            Reads("1111111111.12").As(1111111111.12);
            Reads("1111111111.123").As(1111111111.123);
            Reads("1111111111.1234").As(1111111111.1234);
            Reads("1111111111.12345").As(1111111111.12345);
            Reads("1111111111.123456").As(1111111111.12345);
            Reads("1111111111.1234567").As(1111111111.12345);
            Reads("1111111111.12345678").As(1111111111.12345);
            Reads("1111111111.123456789").As(1111111111.12345);
            Reads("1111111111.1234567891").As(1111111111.12345);

            Reads("11111111111.1").As(11111111111.1);
            Reads("11111111111.12").As(11111111111.12);
            Reads("11111111111.123").As(11111111111.123);
            Reads("11111111111.1234").As(11111111111.1234);
            Reads("11111111111.12345").As(11111111111.1234);
            Reads("11111111111.123456").As(11111111111.1234);
            Reads("11111111111.1234567").As(11111111111.1234);
            Reads("11111111111.12345678").As(11111111111.1234);
            Reads("11111111111.123456789").As(11111111111.1234);

            Reads("111111111111.1").As(111111111111.1);
            Reads("111111111111.12").As(111111111111.12);
            Reads("111111111111.123").As(111111111111.123);
            Reads("111111111111.1234").As(111111111111.123);
            Reads("111111111111.12345").As(111111111111.123);
            Reads("111111111111.123456").As(111111111111.123);
            Reads("111111111111.1234567").As(111111111111.123);
            Reads("111111111111.12345678").As(111111111111.123);

            Reads("1111111111111.1").As(1111111111111.1);
            Reads("1111111111111.12").As(1111111111111.12);
            Reads("1111111111111.123").As(1111111111111.12);
            Reads("1111111111111.1234").As(1111111111111.12);
            Reads("1111111111111.12345").As(1111111111111.12);
            Reads("1111111111111.123456").As(1111111111111.12);
            Reads("1111111111111.1234567").As(1111111111111.12);

            Reads("11111111111111.1").As(11111111111111.1);
            Reads("11111111111111.12").As(11111111111111.1);
            Reads("11111111111111.123").As(11111111111111.1);
            Reads("11111111111111.1234").As(11111111111111.1);
            Reads("11111111111111.12345").As(11111111111111.1);
            Reads("11111111111111.123456").As(11111111111111.1);

            Reads("111111111111111.1").As(111111111111111.0);
            Reads("111111111111111.12").As(111111111111111.0);
            Reads("111111111111111.123").As(111111111111111.0);
            Reads("111111111111111.1234").As(111111111111111.0);
            Reads("111111111111111.12345").As(111111111111111.0);

            Reads("111111111111111E1").As(1111111111111110.0);
            Reads("111111111111111E2").As(11111111111111100.0);
            Reads("111111111111111E3").As(111111111111111000.0);
            Reads("111111111111111E4").As(1111111111111110000.0);
            Reads("111111111111111E5").As(11111111111111100000.0);
            Reads("111111111111111E6").As(111111111111111000000.0);
            Reads("111111111111111E7").As(1111111111111110000000.0);
            Reads("111111111111111E8").As(11111111111111100000000.0);
            Reads("111111111111111E9").As(111111111111111000000000.0);
            Reads("111111111111111E10").As(1111111111111110000000000.0);
            Reads("111111111111111E11").As(11111111111111100000000000.0);
            Reads("111111111111111E12").As(111111111111111000000000000.0);
            Reads("111111111111111E13").As(1111111111111110000000000000.0);
            Reads("111111111111111E14").As(11111111111111100000000000000.0);
            Reads("111111111111111E15").As(111111111111111000000000000000.0);
            Reads("111111111111111E16").As(1111111111111110000000000000000.0);
            Reads("111111111111111E17").As(11111111111111100000000000000000.0);
            Reads("111111111111111E18").As(111111111111111000000000000000000.0);
            Reads("111111111111111E19").As(1111111111111110000000000000000000.0);
            Reads("111111111111111E20").As(11111111111111100000000000000000000.0);
            Reads("111111111111111E21").As(111111111111111000000000000000000000.0);

            Reads("0").As(0.0);
            Reads("0.1").As(0.1);
            Reads("0.02").As(0.02);
            Reads("0.102").As(0.102);
            Reads("0.1002").As(0.1002);
            Reads("0.10203").As(0.10203);
            Reads("0.102034").As(0.102034);
            Reads("0.1020341").As(0.1020341);
            Reads("0.10203411").As(0.10203411);
            Reads("0.102034111").As(0.102034111);
            Reads("0.1020341101").As(0.1020341101);
            Reads("0.10203411001").As(0.10203411001);
            Reads("0.102034110001").As(0.102034110001);
            Reads("0.1020341100001").As(0.1020341100001);
            Reads("0.10203411000001").As(0.10203411000001);
            Reads("0.102034110000001").As(0.10203411);
            Reads("0.1020341100000001").As(0.10203411);
            Reads("0.10203411000000001").As(0.10203411);

            Reads("0.523154234575693").As(0.52315423457569);
        }
    }
}