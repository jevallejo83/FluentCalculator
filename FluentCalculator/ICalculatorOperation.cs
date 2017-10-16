using System;
using System.Collections.Generic;
using System.Text;

namespace FluentCalculator
{
    public interface ICalculatorOperation : ICalculator
    {
        ICalculatorValue Plus { get; }
        ICalculatorValue Times { get; }
        ICalculatorValue DividedBy { get; }

    }
}
