using System;

public abstract class AbstractSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string texto = "Hola Mundo";

   
            NormalClass normal = new NormalClass();
            normal.PrintMessage(texto);
         

          
            CaseClass caso = new CaseClass();
            caso.PrintMessage(texto);
            caso.InvertMessage(texto);
        }
    }

    private string message;

    public abstract void PrintMessage(string msg);

 
    public virtual void InvertMessage(string msg)
    {
        char[] chars = msg.ToCharArray();
        Array.Reverse(chars);
        message = new string(chars);
        Console.WriteLine("Texto Invertido (Orden): " + message);
    }

    protected string Message
    {
        get { return message; }
        set { message = value; }
    }
}


public class NormalClass : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        Message = msg;
        Console.WriteLine("Impresión Normal: " + Message);
    }
}


public class CaseClass : AbstractSample
{

    public override void PrintMessage(string msg)
    {
        char[] chars = msg.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i])) chars[i] = char.ToLower(chars[i]);
            else if (char.IsLower(chars[i])) chars[i] = char.ToUpper(chars[i]);
        }
        Message = new string(chars);
        Console.WriteLine("Impresión Case-Swap: " + Message);
    }


    public override void InvertMessage(string msg)
    {
  
        base.InvertMessage(msg);


        char[] chars = Message.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i])) chars[i] = char.ToLower(chars[i]);
            else if (char.IsLower(chars[i])) chars[i] = char.ToUpper(chars[i]);
        }
        Message = new string(chars);
        Console.WriteLine("Resultado Final (Orden + Case-Swap): " + Message);
    }
}