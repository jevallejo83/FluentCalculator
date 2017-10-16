using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FluentCalculator
{
    public class Calculator : ICalculator, ICalculatorOperation, ICalculatorValue
    {

        private StringBuilder _operatios = new StringBuilder();


        public int Calculate()
        {

            var postFix = ConvertInFixToPostFix(_operatios.ToString());
            int result  = ComputePostFix(postFix);

            return result;
        }

        private int ComputePostFix(string postfix)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var item in postfix)
            {
                int first          = 0;
                int second         = 0;
               
                if(Char.IsNumber(item))
                {
                    stack.Push((int)Char.GetNumericValue(item));
                }
                else
                {
                    first  = stack.Pop();
                    second = stack.Pop();

                    switch (item)
                    {
                        case '+': stack.Push(first + second);
                            break;
                        case '-':
                            stack.Push(first - second);
                            break;
                        case '*':
                            stack.Push(first * second);
                            break;
                        case '/':
                            stack.Push(first + second);
                            break;

                        default:
                            break;
                    }

                }



            }



            return stack.Pop();
        }

        private string ConvertInFixToPostFix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder postfix = new StringBuilder();


            foreach (var item in infix)
            {

                if(Char.IsDigit(item) )
                {
                    postfix.Append(item);
                }
                else 
                {

                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                        continue;
                    }

                    while(stack.Count != 0 && (GetPrecendece(item) <= GetPrecendece(stack.Peek())))
                    {
                        postfix.Append(stack.Pop());                     
                    }

                    stack.Push(item);


                }

            }

            while (stack.Count != 0)
            {
                var c = stack.Pop();
                postfix.Append(c);
            }

            return postfix.ToString();

        }

        private int GetPrecendece(char item)
        {
            switch (item)
            {
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;

                default:
                    return 0;
            }
        }


        #region Values

        public ICalculatorOperation One
        {
            get
            {
                _operatios.Append("1");
                return this;
            }
        }

        public ICalculatorOperation Two
        {
            get
            {
                _operatios.Append("2");
                return this;
            }

        }

        public ICalculatorOperation Three
        {
            get
            {
                _operatios.Append("3");
                return this;
            }

        }

        public ICalculatorOperation Four
        {
            get
            {
                _operatios.Append("4");
                return this;
            }
        }

        public ICalculatorOperation Five
        {
            get
            {
                _operatios.Append("5");
                return this;
            }
        }

        public ICalculatorOperation Six
        {
            get
            {
                _operatios.Append("6");
                return this;
            }
        }

        public ICalculatorOperation Seven
        {
            get
            {
                _operatios.Append("7");
                return this;
            }
        }

        public ICalculatorOperation Eight
        {
            get
            {
                _operatios.Append("8");
                return this;
            }
        }

        public ICalculatorOperation Nine
        {
            get
            {
                _operatios.Append("9");
                return this;
            }
        }

        #endregion

        #region Operators
        public ICalculatorValue Plus
        {
            get
            {
                _operatios.Append("+");
                return this;
            }
        }
        public ICalculatorValue Times
        {
            get
            {
                _operatios.Append("*");
                return this;
            }
        }
        public ICalculatorValue DividedBy
        {
            get
            {
                _operatios.Append("/");
                return this;
            }
        }
        #endregion

    }
}
