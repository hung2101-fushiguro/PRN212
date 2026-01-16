namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1");
            Car wwPolo = new Car();
            wwPolo.Make = "250";
            wwPolo.Model = "Volkswagen Polo";
            wwPolo.Accelerating();
            wwPolo.Braking();
            wwPolo.Starting();
            Console.WriteLine($"Car: {wwPolo}");
            Console.ReadLine();
            Console.WriteLine("Bai 2");
            Customer cus = new Customer();
            cus.CustomerId = 2101;
            Console.WriteLine($"ID:{cus.CustomerId}, Name:{cus.CustomerName}");
            cus.CustomerId = 1234;
            cus.CustomerName = "satoru";
            cus.PrintCustomer();
            Console.ReadLine();
            Console.WriteLine("Bai 3");
            MyClass class1 = new MyClass { x = 10 };
            Console.WriteLine( $"x:{class1.x}, y:{class1.y}");
            MyClass class2 = new MyClass(5, 15);
            Console.WriteLine($"x:{class2.x}, y:{class2.y}");
            MyClass class3 = new MyClass(); 
            Console.WriteLine($"x:{class3.x}, y:{class3.y}");
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Make;
        public string Model;
        public void Starting()
        {
            Console.WriteLine($"{Model} is starting.");
        }
        public void Accelerating()
        {
            Console.WriteLine($"{Model} is accelerating.");
        }
        public void Braking()
        {
            Console.WriteLine($"{Model} is braking.");
        }
        public override string ToString()
        {
            return $"Make = {Make}, Model = {Model}";
        }
    }
    public class Customer
    {
        private int Id;
        public int CustomerId
        {
            get { return Id; }
            set { Id = value; }
        }
        public string CustomerName { get; set; } = "New Customer";
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerId}, Customer Name: {CustomerName}");
        }
    }
    public class MyClass
    {
        public int x { get; init; }
        public int y { get; }
        public MyClass(int a, int b)
        {
            x = a;
            y = b;
        }
        public MyClass()
        {
            x = 21;
            y = 26;
        }    
    }
}
