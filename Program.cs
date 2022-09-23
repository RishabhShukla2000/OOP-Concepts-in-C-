class Program 
{
    void print(int i, int j)
    {
        Console.WriteLine("Sum of 2 numbers : {0}", i + j);
    }
    void print(string a, string b)
    {
        Console.WriteLine("String Concatenation : " + a + b);
    }
    static void Main(string[] args)
    {
        Program prog = new Program();
        prog.print(7, 5);
        prog.print("Hello", "World!!");

        Q3 tech = new Q3();
        String descr = tech.Describe();

        Console.WriteLine(descr);
        Console.ReadKey();
    }
}

abstract class Company
{
    public virtual string Describe()
    {
        return "Work of Company";
    }
}

class Q3 : Company
{
    public override string Describe()
    {
        return "Work of Q3 is to build quality software";
    }
}