namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                var temp1 = 32.9;
                var expected = 91.22;
                var result = TempConverter.converter(temp1);
                Assert.Equal(expected, result);
            }
    }
}