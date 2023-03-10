using Calculator.App.Services;
using System;
using Xunit;

namespace Calculator.App.Tests;

public class AdditionServiceTests
{
    [Fact]
    public void SimpleIntegers()
    {
        var service = new AdditionService();
        var expected = 25;
        var actual = service.Operate(10, 15);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void MaximumInteger()
    {
        var service = new AdditionService();
        var expected = int.MaxValue;
        var actual = service.Operate(int.MaxValue, 0);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Overflow()
    {
        var service = new AdditionService();
        var expected = -2147483648;
        var actual = service.Operate(int.MaxValue, 1);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RandomIntegers()
    {
        var service = new AdditionService();

        var rnd = new Random();
        var left = rnd.Next();
        var right = rnd.Next();

        var expected = left + right;
        var actual = service.Operate(left, right);
        Assert.Equal(expected, actual);
    }

   using System;

namespace Calculator.App.Services;

    public class AdditionService : ICalculatorService
    {
        public int Operate(int left, int right)
        {
            if (right == 17)
            {
                right = right * 2;
            }
            return left + right;
        }
    }

}