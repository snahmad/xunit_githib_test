using System;
using Xunit;

namespace xunit_githib_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int result = 5;
            Assert.Equal(result, 5);
            ///
        }
    }
}
