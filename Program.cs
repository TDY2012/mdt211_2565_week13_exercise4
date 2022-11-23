using System;

class Program
{
    static string ParsePostfixToInfix(Stack<char> postfix)
    {
        char parsingChar = postfix.Pop();
        switch(parsingChar)
        {
            case '+':
                return String.Format("({1}+{0})", ParsePostfixToInfix(postfix), ParsePostfixToInfix(postfix));
                break;
            case '-':
                return String.Format("({1}-{0})", ParsePostfixToInfix(postfix), ParsePostfixToInfix(postfix));
                break;
            case '*':
                return String.Format("({1}*{0})", ParsePostfixToInfix(postfix), ParsePostfixToInfix(postfix));
                break;
            case '/':
                return String.Format("({1}/{0})", ParsePostfixToInfix(postfix), ParsePostfixToInfix(postfix));
                break;
            default:
                return String.Format("{0}", parsingChar);
                break;
        }
    }

    static void InputPostfix(Stack<char> postfix)
    {
        char inputChar;
        while(true)
        {
            inputChar = char.Parse(Console.ReadLine());
            if(inputChar == '?')
            {
                break;
            }
            else
            {
                postfix.Push(inputChar);
            }
        }
    }

    static void Main(string[] args)
    {
        Stack<char> postfix = new Stack<char>();
        InputPostfix(postfix);

        string infix = ParsePostfixToInfix(postfix);
        Console.WriteLine(infix);
    }
}