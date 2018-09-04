using System;
using Xunit;
using cedula;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person persona = new Person("Juan Valiño","55473608");
            string expected = "55473608";
            string actual = persona.CI;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void Test2()
        {
            Person persona = new Person("Juan Perez","11111112");
            string expected = "";
            string actual = persona.CI;
            Assert.Equal(expected,actual);
        }
    }
}