class Methods
{
    public int Sum(int x, int y)
    {
        return x + y;
    }

    public int Sum(int x, int y, int z)
    {
        return x + y + z;
    }
    public int Sum(int x, int y, int z,int c)
    {
        return x + y + z + c;
    }
}

class Plant
{
    private double height;
    private double weight;
    private double width;

    public Plant(double height, double weight)
    {
        this.height = height;
        this.weight = weight;
        this.width = 0.0;
    }

    public Plant(double height, double weight, double width)
    {
        this.height = height;
        this.weight = weight;
        this.width = width;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Рост: {this.height} см, Вес: {this.weight} кг");
    }

    public void DisplayInfo(bool includeWidth)
    {
        Console.WriteLine($"Рост: {this.height} см, Вес: {this.weight} кг" + (includeWidth ? $", Ширина: {this.width} см" : ""));
    }
}

class DoubleArray
{
    private double[] array;

    public DoubleArray(int size)
    {
        array = new double[size];
    }

    public double this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
}


class Program
{
    static void Main(string[] args)
    {
        //РАБОТА С ПЕРЕГРУЗКОЙ МЕТОДА
        Methods calculator = new Methods();

        int result1 = calculator.Sum(1, 2);
        int result2 = calculator.Sum(1, 2, 3);
        int result3 = calculator.Sum(1, 2, 3, 4);

        Console.WriteLine("Результат сложения двух чисел: " + result1);
        Console.WriteLine("Результат сложения трех чисел: " + result2);
        Console.WriteLine("Результат сложения четырех чисел: " + result3);
        Console.WriteLine("\n_________________________________\n");
        //РАБОТА С ПЕРЕГРУЗКОЙ КОНСТРУКТОРА
        Plant plant1 = new Plant(50.0, 2.0);
        Plant plant2 = new Plant(60.0, 3.0, 20.0);

        Console.WriteLine("Информация о растении 1:");
        plant1.DisplayInfo();

        Console.WriteLine("Информация о растении 2:");
        plant2.DisplayInfo(true);
        Console.WriteLine("\n_________________________________\n");
        //РАБОТА С МАССИВОМ
        DoubleArray doubleArray = new DoubleArray(10);

        for (int i = 0; i < 10; i++)
        {
            doubleArray[i] = i * 2.5;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Элемент {i}: {doubleArray[i]}");
        }
        Console.WriteLine("\n_________________________________\n");
    }
}