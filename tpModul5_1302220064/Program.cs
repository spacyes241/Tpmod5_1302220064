// See https://aka.ms/new-console-template for more information

using tpModul5_1302220064;

class Program
{
    static void Main(string[] args)
    {
        string nim = "1234567890";

        Datageneric<string> dataGeneric = new Datageneric<string>(nim);

        dataGeneric.PrintData();
    }
}
