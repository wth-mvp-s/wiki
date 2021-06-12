using System;
using System.Text;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Theory]
        [InlineData("test")]
        public void Test2(string s)
        {
            Assert.Equal(s.Length, this.reverseString(s).Length); 
            Assert.Equal("tset", this.reverseString(s));
            

        }

        //"Write a program that reads a string, reverse it and prints it to the console."
        //"For example: \"introduction\" -> \"noitcudortni\"."

        public string reverseString(string s)
        {
            if (s.Length == 1)
            {
                return s;
            }
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();




        }
    }
}