using DebitCardAssignment;

namespace DebitCardAssignment_UnitTest
{
    public class UnitTest1
    {
        Validate validate = new Validate();
        Account account = new Account();

        [Theory]
        [InlineData(100, 50, 50)]
        [InlineData(233.33, 100.17, 133.16000000000003)]
        [InlineData(double.MinValue, double.MaxValue, 0)]
        public void SubtractFromUserBalance_ShouldWork(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = account.Subtract(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0575")]
        public void ValidatePin_ShouldWork(string pin)
        {
            // Arrange

            // Act
            bool actual = validate.ValidatePin(pin);

            // Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("057")]
        [InlineData("057A")]
        [InlineData("05751")]
        public void ValidatePin_ShouldFail(string pin)
        {
            // Arrange

            // Act
            bool actual = validate.ValidatePin(pin);

            // Assert
            Assert.False(actual);
        }

        [Theory]
        [InlineData("1020304050607080", "Some Date")]
        public void ValidateDebitCard_ShouldWork(string cardnumber, string dateTime)
        {
            // Arrange            

            // Act
            bool actual = validate.ValidateCardnumber(cardnumber, dateTime);

            // Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("102030405060708", "Some Date")]
        [InlineData("102030405060708A", "Some Date")]
        [InlineData("10203040506070801", "Some Date")]
        public void ValidateDebitCard_ShouldFail(string cardnumber, string dateTime)
        {
            // Arrange            

            // Act
            bool actual = validate.ValidateCardnumber(cardnumber, dateTime);

            // Assert
            Assert.False(actual);
        }
    }
}