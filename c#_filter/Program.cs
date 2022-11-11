/* using System;
using System.Text.Json;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var orderList = new OrderList();
                orderList.Add(new Order("EURUSD", 100000, 1.23456));
                orderList.Add(new Order("EURUSD", 200000, 1.0));
                orderList.Add(new Order("EURUSD", 300000, 1.5));
                orderList.Add(new Order("EURUSD", 400000, 1.6));
                orderList.Add(new Order("EURUSD", 500000, 1.7));

                var filteredList = orderList.FilterByPrice(1.5, 1.7);

                foreach (var order in filteredList)
                {
                    foreach (var property in order.GetType().GetProperties())
                    {
                        Console.WriteLine("{0}: {1}", property.Name, property.GetValue(order, null));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(orderList.ToJson());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Thread.Sleep(5000);
            }
        }

        public class Order
        {
            public string Symbol { get; set; }
            public int Volume { get; set; }
            public double Price { get; set; }

            public Order(string symbol, int volume, double price)
            {
                Symbol = symbol;
                Volume = volume;
                Price = price;
            }
        }

        public class OrderList
        {
            private List<Order> _orders = new List<Order>();

            public void Add(Order order)
            {
                if (order.Price < 0)
                {
                    throw new Exception("Price is too low");
                }

                _orders.Add(order);
            }

            public List<Order> FilterByPrice(double minPrice, double maxPrice)
            {
                var filteredList = new List<Order>();

                foreach (var order in _orders)
                {
                    if (order.Price >= minPrice && order.Price <= maxPrice)
                    {
                        filteredList.Add(order);
                    }
                }

                return filteredList;
            }

            public string ToJson()
            {
                return JsonSerializer.Serialize(_orders);
            }
        }

    }
} */