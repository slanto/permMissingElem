using PermMissingElem.Core;
using Xunit;

namespace PermMissingElem.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 5 }, 4)]
        [InlineData(new int[] { 2, 3 }, 1)]
        public void GetMissingElement_ReturnsMissingElementForGivenArray(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.GetMissingElement(array);
            Assert.Equal(expected, actual);
        }
    }
}
