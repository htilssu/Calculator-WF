using System;
using System.Collections.Generic;

namespace WinFormsAppTest
{

    partial class Program
    {
        public static int Calculate(string expression)
        {
            Stack<int> operands = new Stack<int>();
            Stack<char> operators = new Stack<char>();
            Dictionary<char, int> precedence = new Dictionary<char, int>()
        {
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2}
        };

            void ApplyOperation()
            {
                char op = operators.Pop();
                int operand2 = operands.Pop();
                int operand1 = operands.Pop();
                int result;

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

            foreach (char c in expression)
            {
                if (char.IsDigit(c))
                {
                    operands.Push(int.Parse(c.ToString()));
                }
                else if (precedence.ContainsKey(c))
                {
                    while (operators.Count > 0 && operators.Peek() != '(' && precedence[c] <= precedence[operators.Peek()])
                    {
                        ApplyOperation();
                    }

                    operators.Push(c);
                }
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
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