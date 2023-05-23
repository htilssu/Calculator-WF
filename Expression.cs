using System;
using System.Collections.Generic;

namespace WinFormsAppTest
{

    partial class Program
    {
        public static double Calculate(string expression)
        {
            Stack<double> operands = new Stack<double>();
            Stack<char> operators = new Stack<char>();
            Dictionary<char, int> precedence = new Dictionary<char, int>()
        {
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2}
        };
            int GetNumber(ref int index)
            {
                int number = 0;
                while (index < expression.Length && char.IsDigit(expression[index]))
                {
                    number = number * 10 + (expression[index] - '0');
                    index++;
                }
                index--;
                return number;
            }

            void ApplyOperation()
            {
                char op = operators.Pop();
                double operand2 = operands.Pop();
                double operand1 = operands.Pop();
                double result;

                switch (op)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        result = operand1 / operand2;
                        break;
                    default:
                        throw new ArgumentException("Invalid operator");
                }
                operands.Push(result);
            }

            for (int i = 0; i < expression.Length; i++)
            
            {
                if (char.IsDigit(expression[i]))
                {
                    int number = GetNumber(ref i);
                    operands.Push(number);
                }
                else if (precedence.ContainsKey(expression[i]))
                {
                    while (operators.Count > 0 && operators.Peek() != '(' && precedence[expression[i]] <= precedence[operators.Peek()])
                    {
                        ApplyOperation();
                    }

                    operators.Push(expression[i]);
                }
                else if (expression[i] == '(')
                {
                    operators.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        ApplyOperation();
                    }

                    operators.Pop(); // Pop '('
                }
            }

            while (operators.Count > 0)
            {
                ApplyOperation();
            }

            return operands.Pop();
        }

    }
}