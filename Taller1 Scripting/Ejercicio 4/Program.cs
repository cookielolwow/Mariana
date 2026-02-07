using System;


class AbstractSample
{   public virtual void PrintMessage()
    {
        Console.WriteLine("Mensaje desde AbstractSample");
    }
}

class MessageManager
{
    public void ManageMessages()
    {
     
        AbstractSample sample1 = new AbstractSample();
        AbstractSample sample2 = new AbstractSample();

 
        sample1.PrintMessage();
        sample2.PrintMessage();
    }


    static void Main(string[] args)
    {
        MessageManager manager = new MessageManager();
        manager.ManageMessages();
    }
}