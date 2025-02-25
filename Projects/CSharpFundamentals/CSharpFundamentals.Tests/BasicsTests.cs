using CSharpFundamentals.Basics;

namespace CSharpFundamentals.Tests
{
    public class BasicsTests
    {
        [Fact]
        public void CalculateAddition_ShouldReturnCorrectAmount()
        {
            int expectedResult = 8;

            int result = Methods.MethodsDemoAddition(5, 3);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SafeDivision_ShouldHandleDivisionByZero()
        {
            var exception = Record.Exception(() => { int result = 10 / 0; });
            Assert.NotNull(exception);
            Assert.IsType<DivideByZeroException>(exception);
        }
    }
}
