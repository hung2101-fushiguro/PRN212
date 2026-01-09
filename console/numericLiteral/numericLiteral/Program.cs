class NumericLiteral
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Use Digit Sperators ****");
        Console.Write("Integer: ");
        Console.WriteLine(123_456);
        Console.Write("Double :");
        Console.WriteLine(123_456.12);
        Console.Write("Hex: ");
        Console.WriteLine(0x_00_00_FF);
        Console.WriteLine("**** Use Binary Literals ****");
        Console.WriteLine("Sixteen : {0}", 0b0001_0000);
        Console.ReadLine();

    }
}