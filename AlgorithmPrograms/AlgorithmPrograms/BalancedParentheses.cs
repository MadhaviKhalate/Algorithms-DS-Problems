﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgorithmPrograms
{
    internal class BalancedParentheses
    {
        public void BalancedParantheses(string exp)
        {
            Stack stk = new Stack();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
                    stk.Push(exp[i]);
                else if (exp[i] == ')' && stk.Count != 0 && (char)stk.Peek() == '(')
                    stk.Pop();
                else if (exp[i] == '}' && stk.Count != 0 && (char)stk.Peek() == '{')
                    stk.Pop();
                else if (exp[i] == ']' && stk.Count != 0 && (char)stk.Peek() == '[')
                    stk.Pop();
            }
            if (stk.Count == 0)
            {
                Console.WriteLine("Arithmetic Expression is Balanced.");
                return;
            }
            Console.WriteLine("Arithmetic Expression is not balanced.");
        }
    }
}
