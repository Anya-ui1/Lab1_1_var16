namespace TestLab1
{
    public class FirsttPartTests
    {
        [Fact]
        public void CheckSumBeforeZero()
        {
            var testArray = new[] { 1, 2, -5, 4, 0, 6, 3 };
            const int expectedSum = 2;

            var realSum = Lab1.GetSumBeforeZero(testArray);
            Assert.Equal(expectedSum, realSum);
        }

        [Fact]
        public void CheckSumBeforeZeroWithoutZero()
        {
            var testArray = new[] { 1, 2, 3, 4, 5, 6, 6 };
            var expectedSum = testArray.Sum();

            Assert.Equal(expectedSum, Lab1.GetSumBeforeZero(testArray));
        }
        [Fact]
        public void CheckSum()
        {
            var testArray = new[] { 3, 2, -5, -1, 0, -6, 3 };
            const int expectedSum1 = 8;

            int v = Lab1.GetSum(testArray);
     
            Assert.Equal(expectedSum1, v);
        }
    }
}