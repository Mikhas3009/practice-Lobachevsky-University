using clases_2task_;
using System;
using System.Text.Json;


public class IntChangedEventArgs : EventArgs
{
    public int NewValue { get; set; }
}

public class IntManager
{
    private int value=0;

    public event EventHandler<IntChangedEventArgs> ValueChanged; // Объявление события

    public int Value
    {
        get { return value; }
        set
        {
            if (value < this.value)
            {
                this.value = value;
                OnValueChanged(new IntChangedEventArgs { NewValue = value });
            }
        }
    }

    protected virtual void OnValueChanged(IntChangedEventArgs e)
    {
        EventHandler<IntChangedEventArgs> handler = ValueChanged;
        handler?.Invoke(this, e);
    }
}

public class Program
{
    static List<Order> freezeOrders;
    static Courier[] allCouriers;
    static Baker[] allBakers;
    static IntManager manager;
    static int skladSize;
    public static  void Main()
    {
        Random random = new Random();
        manager = new IntManager();
        skladSize   = Convert.ToInt32(File.ReadAllText("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\sklad.txt"));
        string bakersParams = (File.ReadAllText("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\bakers.txt"));
        string couriersParams = File.ReadAllText("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\couriers.txt");
        var bakers = bakersParams.Split('\n');
        var couriers = couriersParams.Split('\n');
        allBakers = new Baker[bakers.Length];
        allCouriers= new Courier[bakers.Length];
        freezeOrders = new List<Order>();
        for (int i = 0; i < allBakers.Length; i++) {
            var properties=  bakers[i].Split('|');
            allBakers[i] = new Baker(Convert.ToInt16(properties[2]), properties[1], Convert.ToInt16(properties[0]));
        }
        for (int i = 0; i < allCouriers.Length; i++)
        {
            var properties = couriers[i].Split('|');
            allCouriers[i] = new Courier(Convert.ToInt16(properties[2]), properties[1], Convert.ToInt16(properties[0]));
        }
        manager.ValueChanged += ValueChangedHandler; 
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("1 - cделать заказ");
            string op = Console.ReadLine();
            switch (op) {

                case "1": {
                        Console.WriteLine("Введите название пиццы");
                        string pizzaName = Console.ReadLine();
                        var pizze = new Pizza(random.Next(10,20),pizzaName);
                        Console.WriteLine("Введите адрес");
                        string address = Console.ReadLine();
                        var order = new Order(pizze, Guid.NewGuid(),address);
                        try {
                            order.defineBakers(allBakers);
                        }
                        catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                        try {
                            order.startCooking(allCouriers, manager, skladSize,freezeOrders);
                        }
                        catch {
                            freezeOrders.Insert(0,order);
                        }

                        break;

                     }

                default:
                    {
                        flag = false;
                        break;
                    }
                   
            }
        }
        string output = (File.ReadAllText("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"));
        Console.WriteLine(output) ;
    }

    private static void ValueChangedHandler(object sender, IntChangedEventArgs e)
    {
        var order = freezeOrders.Last();
        order.startCooking(allCouriers,manager,skladSize,freezeOrders);
        freezeOrders.RemoveAt(freezeOrders.Count-1);
    }
}