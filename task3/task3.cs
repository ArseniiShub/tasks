using System;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class task3
    {
        static void Main(string[] args)
        {
            tokens = new Queue<string>(Console.ReadLine().Split(' '));
            Console.WriteLine(DoTheWork(tokens));
        }
        static Queue<string> tokens;
        static Stack<string> result = new Stack<string>();
        static string DoTheWork(Queue<string> tokens)
        {
            while (!IsOperator(tokens.FirstOrDefault()) && tokens.Count != 0)
            {
                result.Push(tokens.Dequeue());
            }
            if (result.Count > 1)
                result.Push(MakeOperation(result.Pop(), tokens.Dequeue(), result.Pop()));
            else
                return result.First();
            if(tokens.Count != 0)
                DoTheWork(tokens);
            return result.First();
        }

        static bool IsOperator(string line)
        {
            return line == "+" || line == "-" || line == "*" || line == "/";
        }

        static string MakeOperation(string secondOperand, string op, string firstOperand)
        {
            int first = Convert.ToInt32(firstOperand);
            int second = Convert.ToInt32(secondOperand);
            int result;
            switch (op)
            {
                case "+": result = first + second; break;
                case "-": result = first - second; break;
                case "*": result = first * second; break;
                case "/": result = first / second; break;
                default: throw new ArgumentException("Unsupported Operation");
            }
            return result.ToString();
        }
    }
}
