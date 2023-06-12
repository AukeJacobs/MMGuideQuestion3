using CheckForAnagramApp;

namespace AnagramCheckerTests
{
    public class AnagramCheckerTests
    {
        [Fact]
        public void IsAnagramTrue()
        {
            Assert.True(AnagramChecker.AreAnagram("a gentleman", "elegant man"));
        }

        [Fact]
        public void IsAnagramFalse()
        {
            Assert.False(AnagramChecker.AreAnagram("a sf sdggentleman", "eledfssdf"));
        }

        [Fact]
        public void IsAnagramTrueNoSort()
        {
            Assert.True(AnagramChecker.AreAnagramNoSort("a gentleman", "elegant man"));
        }

        [Fact]
        public void IsAnagramFalseNoSort()
        {
            Assert.False(AnagramChecker.AreAnagramNoSort("a sf sdggentleman", "eledfssdf"));
        }
    }
}