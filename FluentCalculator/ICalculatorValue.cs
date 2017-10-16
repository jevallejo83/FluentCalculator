using System;
using System.Collections.Generic;
using System.Text;

namespace FluentCalculator
{
    public interface ICalculatorValue
    {

        ICalculatorOperation One    { get; }
        ICalculatorOperation Two    { get; }
        ICalculatorOperation Three  { get; }
        ICalculatorOperation Four   { get; }
        ICalculatorOperation Five   { get; }
        ICalculatorOperation Six    { get; }
        ICalculatorOperation Seven  { get; }
        ICalculatorOperation Eight  { get; }
        ICalculatorOperation Nine   { get; }
    }
}
