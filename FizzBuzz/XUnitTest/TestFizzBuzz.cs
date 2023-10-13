using Xunit;

namespace FizzBuzz.XUnitTest
{
	public class TestFizzBuzz
	{
        private FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();

        [Fact]
        public void shouldReturnNotNullFizzBuzz()
        {
            string[] actual = fizzBuzzClass.fizzBuzz(3);
            Assert.NotNull(actual);
        }

        [Fact]
        public void shouldReturnFromNumberOneToNumberThree()
        {
            string[] actual = fizzBuzzClass.fizzBuzz(3);
            string[] expected = { "1", "2", "Fizz" };
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void shouldReturnFizzWhenNumberIsDivisibleByThree()
        {
            string[] actual = fizzBuzzClass.fizzBuzz(4);
            string[] expected = { "1", "2", "Fizz", "4" };
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void shouldReturnBuzzWhenNumberIsDivisibleByFive()
        {
            string[] actual = fizzBuzzClass.fizzBuzz(5);
            string[] expected = { "1", "2", "Fizz", "4", "Buzz" };
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void shouldReturnFizzBuzzWhenNumberIsDivisibleByThreeAndFive()
        {
            string[] actual = fizzBuzzClass.fizzBuzz(15);
            string[] expected = { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };
            Assert.Equal(actual, expected);
        }
    }
}

