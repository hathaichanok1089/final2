using System;

class Program
{
    static string[] supportsymbol = new string[]{'(', ')'};

    static void Inputsymbol(Queue<string> charactor)
    {
        string symbol = (Console.ReadLine());
        if(supportsymbolArray.Contains(symbol))
        {
            charactor.Push(symbol);
            Inputsymbol(charactor);
        }
    }
    
   
    static void Processcharactor(Queue<string> charactor)
    {
        string symbol;
        while(charactor.GetLength() > 0)
        {
            symbol = charactor.Pop();
            switch(symbol)
            {
                case '(':
                    Console.Write(valid);
                    break;
                case ')':
                    Console.Write(valid);
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Queue<string> charactor = new Queue<string>();
        Inputsymbol(charactor);
        Processcharactor(charactor);
    }
}