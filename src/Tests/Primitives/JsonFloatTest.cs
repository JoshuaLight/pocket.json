﻿using Xunit;

namespace Pocket.Json.Tests.Primitives
{
    public class JsonFloatTest : JsonTest
    {
        [Fact]
        public void Write_ShouldWorkCorrectly()
        {
            Writes(0f).As("0");
            Writes(0.0f).As("0");
            Writes(0.1f).As("0.1");
            Writes(0.01f).As("0.01");
            Writes(0.001f).As("0.001");
            Writes(0.0001f).As("0.0001");
            Writes(0.00001f).As("0.00001");
            Writes(0.000001f).As("0.000001");
            Writes(0.0000001f).As("0.0000001");
            Writes(0.00000001f).As("0");

            Writes(1.1f).As("1.1");
            Writes(1.12f).As("1.12");
            Writes(1.123f).As("1.123");
            Writes(1.1234f).As("1.1234");
            Writes(1.12345f).As("1.12345");
            Writes(1.123456f).As("1.123456");
            Writes(1.1234567f).As("1.123457");
            Writes(1.12345678f).As("1.123457");

            Writes(11.1f).As("11.1");
            Writes(11.12f).As("11.12");
            Writes(11.123f).As("11.123");
            Writes(11.1234f).As("11.1234");
            Writes(11.12345f).As("11.12345");
            Writes(11.123456f).As("11.12346");
            Writes(11.1234567f).As("11.12346");
            Writes(11.12345678f).As("11.12346");

            Writes(111.1f).As("111.1");
            Writes(111.12f).As("111.12");
            Writes(111.123f).As("111.123");
            Writes(111.1234f).As("111.1234");
            Writes(111.12345f).As("111.1235");
            Writes(111.123456f).As("111.1235");
            Writes(111.1234567f).As("111.1235");

            Writes(1111.1f).As("1111.1");
            Writes(1111.12f).As("1111.12");
            Writes(1111.123f).As("1111.123");
            Writes(1111.1234f).As("1111.123");
            Writes(1111.12345f).As("1111.123");
            Writes(1111.123456f).As("1111.123");

            Writes(11111.1f).As("11111.1");
            Writes(11111.12f).As("11111.12");
            Writes(11111.123f).As("11111.12");
            Writes(11111.1234f).As("11111.12");
            Writes(11111.12345f).As("11111.12");

            Writes(111111.1f).As("111111.1");
            Writes(111111.12f).As("111111.1");
            Writes(111111.123f).As("111111.1");
            Writes(111111.1234f).As("111111.1");

            Writes(1111111f).As("1111111");
            Writes(1111111.1f).As("1111111");
            Writes(1111111.12f).As("1111111");
            Writes(1111111.123f).As("1111111");

            Writes(11111111f).As("1111111E1");
            Writes(111111111f).As("1111111E2");
            Writes(1111111111f).As("1111111E3");
            Writes(11111111111f).As("1111111E4");
            Writes(111111111111f).As("1111111E5");
            Writes(1111111111111f).As("1111111E6");
            Writes(11111111111111f).As("1111111E7");
            Writes(111111111111111f).As("1111111E8");
            Writes(1111111111111111f).As("1111111E9");
            Writes(11111111111111111f).As("1111111E10");
            Writes(111111111111111111f).As("1111111E11");
            Writes(1111111111111111111f).As("1111111E12");
            Writes(11111111111111111111f).As("1111111E13");
            Writes(111111111111111111111f).As("1111111E14");
            Writes(1111111111111111111111f).As("1111111E15");
            Writes(11111111111111111111111f).As("1111111E16");
            Writes(111111111111111111111111f).As("1111111E17");
            Writes(1111111111111111111111111f).As("1111111E18");

            Writes(0f).As("0");
            Writes(0.1f).As("0.1");
            Writes(0.02f).As("0.02");
            Writes(0.102f).As("0.102");
            Writes(0.1002f).As("0.1002");
            Writes(0.10203f).As("0.10203");
            Writes(0.102034f).As("0.102034");
        }

        [Fact]
        public void Read_ShouldWorkCorrectly()
        {
            Reads("0").As(0f);
            Reads("0.0").As(0f);
            Reads("0.1").As(0.1f);
            Reads("0.01").As(0.01f);
            Reads("0.001").As(0.001f);
            Reads("0.0001").As(0.0001f);
            Reads("0.00001").As(0.00001f);
            Reads("0.000001").As(0.000001f);
            Reads("0.0000001").As(0.0f);
            Reads("0.00000001").As(0.0f);
            Reads("0.000000001").As(0.0f);
            Reads("0.0000000001").As(0.0f);
            Reads("0.00000000001").As(0.0f);

            Reads("1.1").As(1.1f);
            Reads("1.12").As(1.12f);
            Reads("1.123").As(1.123f);
            Reads("1.1234").As(1.1234f);
            Reads("1.12345").As(1.12345f);
            Reads("1.123456").As(1.123456f);
            Reads("1.123456").As(1.123456f);

            Reads("11.1").As(11.1f);
            Reads("11.12").As(11.12f);
            Reads("11.123").As(11.123f);
            Reads("11.1234").As(11.1234f);
            Reads("11.12345").As(11.12345f);
            Reads("11.12345").As(11.12345f);
            Reads("11.12345").As(11.12345f);

            Reads("111.1").As(111.1f);
            Reads("111.12").As(111.12f);
            Reads("111.123").As(111.123f);
            Reads("111.1234").As(111.1234f);
            Reads("111.1234").As(111.1234f);
            Reads("111.1234").As(111.1234f);

            Reads("1111.1").As(1111.1f);
            Reads("1111.12").As(1111.12f);
            Reads("1111.123").As(1111.123f);
            Reads("1111.123").As(1111.123f);
            Reads("1111.123").As(1111.123f);

            Reads("11111.1").As(11111.1f);
            Reads("11111.12").As(11111.12f);
            Reads("11111.12").As(11111.12f);
            Reads("11111.12").As(11111.12f);

            Reads("111111.1").As(111111.1f);
            Reads("111111.1").As(111111.1f);
            Reads("111111.1").As(111111.1f);
            Reads("1111111.1").As(1111111.0f);

            Reads("1111111").As(1111111f);
            Reads("1111111E1").As(11111110f);
            Reads("1111111E2").As(111111100f);
            Reads("1111111E3").As(1111111000f);
            Reads("1111111E4").As(11111110000f);
            Reads("1111111E5").As(111111100000f);
            Reads("1111111E6").As(1111111000000f);
            Reads("1111111E7").As(11111110000000f);
            Reads("1111111E8").As(111111100000000f);
            Reads("1111111E9").As(1111111000000000f);
            Reads("1111111E10").As(11111110000000000f);
            Reads("1111111E11").As(111111100000000000f);
            Reads("1111111E12").As(1111111000000000000f);

            Reads("0.102").As(0.102f);
            Reads("0.1002").As(0.1002f);
            Reads("0.10203").As(0.10203f);
            Reads("0.102034").As(0.102034f);
            Reads("0.1020034").As(0.102003f);
            Reads("0.10200034").As(0.102f);
        }
    }
}