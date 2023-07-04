using FizzBuzz.Game;

namespace FizzBuzz.Tests
{
    public class GameTest
    {
        //[Fact]
        //public void IsExist()
        //{
        //    var gameBoard = new FizzBuzz.Game.FizzBuzzBoard();
        //    var number = 3;
        //    string response = gameBoard.GetWordForNumber(number);
        //}

        FizzBuzzBoard board = new FizzBuzz.Game.FizzBuzzBoard();
        [Fact]
        public void When_Send_Three_Return_Fizz()
        {
            var number = 3;
            string actual = board.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);

        }

        [Fact]
        public void When_send_Five_return_Buzz()
        {
            var number = 5;
            string actual = board.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void When_send_Multiply_Three_return_Fizz(int number)
        {

            string actual = board.GetWordForNumber(number);
            Assert.Equal("Fizz", actual);
        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void When_send_Multiply_Five_return_Buzz(int number)
        {

            string actual = board.GetWordForNumber(number);
            Assert.Equal("Buzz", actual);
        }


        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void When_send_Multiply_Fifteen_return_FizzBuzz(int number)
        {

            string actual = board.GetWordForNumber(number);
            Assert.Equal("FizzBuzz", actual);
        }



    }
}