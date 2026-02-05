using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class MyClass
{
    /*public static void Main(string[] args)
    {     
        int [] numbers = { 10, 20, 30, 40, 50 };
        //int[] numbers1 = new int[5] ;   
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("el array tiene "+numbers.Length+" números");
        //Console.WriteLine($"numbers1[]: {numbers1[0]}");

        List<int> numberlist = new() { 10,20,30,40,50};
        List<int> numberlist1 = new() ;
        List<int> numberlist2 = new List<int>(5);


        static void PrintListElements(List<int> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }

        PrintListElements(numberlist);
        Console.WriteLine(" ---- ");
        numberlist1.Add(54762398);
        Console.WriteLine(" ---- ");
        PrintListElements(numberlist1);

        Console.WriteLine(" ---- ");
        Console.WriteLine(" ---- "); 
        
        PrintListElements(numberlist2);
        Console.WriteLine(" ---- ");


        
        Console.WriteLine(" ---- ");
        numberlist[1] = 0;
            PrintListElements(numberlist);

        for (int i = 0; i < 20; i++)
        {
           numberlist2.Add(i * 111);
        }

        foreach (var item in numberlist)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("la lista tiene " + numberlist.Count + " números");
        Console.WriteLine("la lista tiene " + numberlist1.Count + " números");
        Console.WriteLine("la lista tiene " + numberlist2.Count + " números");

        Console.WriteLine($"numberList[{3}]:{numberlist[3]}");

        int Index=0;
        while (Index < numbers.Length)
        {
                       Console.WriteLine($"numbers[{Index}]: {numbers[Index]}");
            Index++;
    
        }

        int Index1 = 0;
        while (Index1 < numberlist2.Count)
        {
            Console.WriteLine($"numbers[{Index1}]: {numberlist2[Index1]}");
            Index1++;

        }*/

    public static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        Console.WriteLine("stacks elements " + stack.Count );

        
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        Console.WriteLine("---------" );

        foreach (var item in stack)
        { Console.WriteLine(item); }
        Console.WriteLine("---------");

        string top = stack.Pop();
  
        Console.WriteLine(top);
        Console.WriteLine("---------");
        foreach (var item in stack)
        { Console.WriteLine(item); }
                Console.WriteLine("---------" );
      

        stack.Push(top);

        foreach (var item in stack)
        { Console.WriteLine(item); }
        Console.WriteLine("---------");
        Console.WriteLine("stacks elements " + stack.Count);
    }
}