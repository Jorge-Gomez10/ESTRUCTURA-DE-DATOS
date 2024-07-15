//VERIFICACION DE UNA OPERACION MATEMATICA

using System;
using System.Collections.Generic;

class Program
{
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                {
                    return false;
                }

                char top = pila.Pop();

                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0;
    }

    static void Main(string[] args)
    {
        string expresion = "{7+(8*5)-[(9-7)+(4+1)]}";

        if (EstaBalanceada(expresion))
        {
            Console.WriteLine("La fórmula está balanceada.");
        }
        else
        {
            Console.WriteLine("La fórmula no está balanceada.");
        }
    }
}
