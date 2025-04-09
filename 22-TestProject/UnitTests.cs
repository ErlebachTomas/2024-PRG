using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_TestProject
{
    public class UnitTests
    {
        [Fact]
        public void Collection_ShouldContainExpectedValues()
        {
            var numbers = new List<int> { 1, 2, 3 };

            Assert.Collection(numbers,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item));
        }

        [Fact]
        public void AllNumbers_ShouldBePositive()
        {
            var numbers = new List<int> { 1, 2, 3, 100 };

            Assert.All(numbers, item => Assert.True(item > 0));
        }
    }
}
