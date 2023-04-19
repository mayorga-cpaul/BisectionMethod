using NumericMethod.Services.Util;

namespace NumericMethod.Tests.ServicesTest;

[TestFixture]
public class FunctionValidatorTests
{
    [Test]
    public void TestValidFunctionX()
    {
        // Arrange
        var function = "2*x + 1";

        // Act
        var result = FunctionValidator.Validate(function);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void TestInvalidFunctionX()
    {
        // Arrange
        var function = "1 / (x - 2)";

        // Act
        var result = FunctionValidator.Validate(function);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void TestValidFunctionXY()
    {
        // Arrange
        var function = "x^2 + 2*x*y - 10";

        // Act
        var result = FunctionValidator.ValidateTwoVariables(function);

        // Assert
        Assert.IsTrue(result);
    }
}

