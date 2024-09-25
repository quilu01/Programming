class Program
{
    public static void Main(string[] args)
    {
        List<int> ints = new List<int> { 1, 2, 3, 4 };
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
        List<string> strings = new List<string> { "ab", "bc" };
        foreach(string s in strings)
        {
            Console.WriteLine(s);
        }
        ints.Add(1);
        ints.Remove(1);
        ints.IndexOf(1);
        ints.Insert(2, 2);
        strings.Add("abc");
        strings.Remove("abc");
        strings.Insert(2, "abcd");
        Car car1 = new Car();
        Car car2 = new Car();
        List<Car> cars = new List<Car> { car1, car2 };
        foreach(Car car in cars)
        {
            Console.WriteLine(car.Name);
        }
        var sortedInts = ints.OrderBy(num => num);
        var squares = ints.Select(num => num * num);
        var even = ints.Where(num => num % 2 == 0);
        int maxInt = ints.Max();
        int minInt = ints.Min();
        double average = ints.Average();
        int sum = ints.Sum();
        try
        {
            car1.Name = "negr";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Car
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { if (value == "negr") { throw new Exception(); } }
    }
    public void Rename(string newName)
    {
        Name = newName;
    }

}
