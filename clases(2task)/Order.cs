using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_2task_
{
    internal class Order
    {
        Random random = new Random();
        public Order(Pizza pizza, Guid id,string address) {
            this.pizza = pizza;
            this.id = id;
            this.address = address;
            this.timeComplete = new(0,random.Next(10,30));
            this.status = "Заказ принят";
        }

        public readonly Guid id;
        private Pizza pizza;
        private Baker baker;
        private Courier courier;
        private TimeOnly timeComplete { get; set; }
        private string status { get; set; }
        private readonly string address;

        public void defineBakers(Baker[] allBakers) {
            foreach (var baker in allBakers)
            {
                if (baker.getStatus() != "buzy") { 
                    this.baker = baker;
                    baker.setStatus("buzy");
                    Console.WriteLine("Пекарь "+baker.fio+ "Назначен на заказ: " + this.id);
                    return;
                }
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"))
            {
                writer.Write("Рекомендую расширить штат пекарей ");
            }
            throw new Exception("Все пекари заняты, попробуйте позже");
        }

        public async void startCooking(Courier[] allCouriers, IntManager manager, int skladSize, List<Order> freezeOrders) {
            int time = this.pizza.getTimeCook();
            var timeCook = random.Next(time-5,time +5);
            if (time < timeCook) {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"))
                {
                    writer.Write("Рекомендую уволить повара " + this.baker.fio);
                }
            }
            if (this.status != "Пицца готова")
            {
                await Task.Delay(timeCook * 1000);
            }
            Console.WriteLine("Заказ номер " +this.id+" приготовился, заказ отправляется на склад");
            this.status = "Пицца готова";
            this.baker.setStatus("free");
            if (manager.Value < skladSize)
            {
                try
                {
                    this.defineCourier(allCouriers);
                    manager.Value++;
                }
                catch {
                    this.baker.setStatus("buzy");
                }
            }
            else {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"))
                {
                    writer.Write("Рекомендую расширить склад ");
                }
                throw new Exception("Склад заполнен");
            }
            
        }

        public void defineCourier(Courier[] allCouriers) {
            foreach (var courier in allCouriers)
            {
                if (courier.getStatus() != "buzy")
                {
                    this.courier = courier;
                    courier.setStatus("buzy");
                    Console.WriteLine("Курьер " + courier.fio + "Назначен на заказ: "+ this.id);
                    this.startDelievery();
                    return;
                }
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"))
            {
                writer.Write("Рекомендую расширить штат курьеров");
            }
            throw new Exception("Все курьеры заняты!!!");
        }

        public async void startDelievery() {
            Console.WriteLine("Курьер забрал ваш заказ!");
            int time = random.Next(5,40/(this.courier.getExpirience()+5));
            await Task.Delay(time*1000*60);
            Console.WriteLine("Заказ номер " + this.id + " доставлен!");
            if (time > this.timeComplete.Minute) {
                Console.WriteLine("Курьер опоздал, пицца бесплатно!");
                using (StreamWriter writer = new StreamWriter("C:\\Users\\prusa\\OneDrive\\Рабочий стол\\Учеба\\Учеба\\с#\\2 дз\\clases(2task)\\output.txt"))
                {
                    writer.Write("Рекомендую уволить курьера " + this.courier.fio);
                }
            }
            this.status = "Complete";
            this.courier.setStatus("free");
        }

    }
}
