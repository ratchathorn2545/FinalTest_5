using System;



class Program
{
    static void Main(string[] args)
    {

        int numitem, n;
        string itemname, itemtype;
        Console.Write("Number of item in bag; ");
        n = int.Parse(Console.ReadLine());

        for (numitem = 1; numitem <= n; numitem++) ;
        {
            Console.WriteLine("Input Item: ");
            itemname = Console.ReadLine();
            Console.WriteLine("Input Type: ");
            itemtype = Console.ReadLine();
        }
        Console.WriteLine("Input ShowAll or Itemtype: ");
        string showall = Console.ReadLine();

        if (showall == "ShowAll")
        {
            Console.Write(" ");
            Console.WriteLine();
        }
    }
}


   

