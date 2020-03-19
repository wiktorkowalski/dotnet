using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace zadanie4
{
    class Calculator
    {
        #region singleton
        private static Calculator calculator;
        private Calculator() { }
        public static Calculator GetCalculator()
        {
            calculator = calculator ?? new Calculator();
            return calculator;
        }
        #endregion

        private Stack<Token> rpnTokens = new Stack<Token>();
        private Stack<Token> infixTokens = new Stack<Token>();
        private double result = 0;

        public double Calculate(string input)
        {
        //    rpnTokens = new Stack<Token>();
        //    infixTokens = new Stack<Token>();
            validateInput(input);
            parseInputToInfixTokens(input);
            parseInputToRPN(infixTokens);
            calculateRPN(rpnTokens);
            return result;
        }

        private void validateInput(string input)
        {
            //validate
        }

        private void parseInputToInfixTokens(string input)
        {
            var temp = Regex.Split(input, @"([\+\-\*\/])");
            foreach (var item in temp)
            {
                infixTokens.Push(new Token(item));
            }
            //infixTokens = new Stack<Token>(infixTokens.Reverse());
            var rev = new Stack<Token>();
            while (infixTokens.Count != 0)
            {
                rev.Push(infixTokens.Pop());
            }
            infixTokens = rev;
        }

        private void parseInputToRPN(Stack<Token> infixTokens)
        {
            Stack<Token> operators = new Stack<Token>();
            while (infixTokens.Count != 0)
            {
                //number
                if (infixTokens.Peek().isNumber()) rpnTokens.Push(infixTokens.Pop());
                //operator
                else
                {
                    while (operators.Count != 0 && infixTokens.Peek().GetPriority() <= operators.Peek().GetPriority())
                        rpnTokens.Push(operators.Pop());
                    operators.Push(infixTokens.Pop());
                }
            }
            while (operators.Count != 0) rpnTokens.Push(operators.Pop());
            //rpnTokens.Reverse();
            var rev = new Stack<Token>();
            while (rpnTokens.Count != 0)
            {
                rev.Push(rpnTokens.Pop());
            }
            rpnTokens = rev;
        }

        private void calculateRPN(Stack<Token> rpnTokens)
        {
            Stack<double> local = new Stack<double>();
            while (rpnTokens.Count != 0)
            {
                if (rpnTokens.Peek().isNumber()) local.Push(rpnTokens.Pop().GetDoubleValue());

                else if (rpnTokens.Peek().isOperator())
                {
                    switch (rpnTokens.Pop().Value)
                    {
                        case "+":
                            {
                                local.Push(local.Pop() + local.Pop());
                                break;
                            }
                        case "-":
                            {
                                local.Push(local.Pop() - local.Pop());
                                break;
                            }
                        case "*":
                            {
                                local.Push(local.Pop() * local.Pop());
                                break;
                            }
                        case "/":
                            {
                                local.Push(local.Pop() / local.Pop());
                                break;
                            }
                    }

                }
            }
            result = local.Pop();
        }
    }
}
