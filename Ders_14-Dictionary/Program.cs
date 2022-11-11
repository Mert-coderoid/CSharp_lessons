using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary 
            try
            {
                Dictionary<int, string> users = new Dictionary<int, string>();

                users.Add(10, "Mert Yılmaz");
                users.Add(20, "Mehmet Yılmaz");
                users.Add(30, "Ahmet Yılmaz");

                Console.WriteLine(users[10]);

                foreach (var user in users)
                {
                    Console.WriteLine(user);
                }

                // count
                Console.WriteLine("Count: " + users.Count);

                // contains
                Console.WriteLine("Contains: " + users.ContainsKey(10));
                Console.WriteLine("Contains: " + users.ContainsKey(11));

                Console.WriteLine("Contains: " + users.ContainsValue("Mert Yılmaz"));
                Console.WriteLine("Contains: " + users.ContainsValue("Mert Yılmaz1"));

                // // remove
                // users.Remove(10);
                // Console.WriteLine("Count: " + users.Count);

                // // clear
                // users.Clear();
                // Console.WriteLine("Count: " + users.Count);

                // SortedDictionary
                SortedDictionary<int, string> sortedUsers = new SortedDictionary<int, string>();

                sortedUsers.Add(30, "Ahmet Yılmaz");
                sortedUsers.Add(10, "Mert Yılmaz");
                sortedUsers.Add(20, "Mehmet Yılmaz");

                foreach (var user in sortedUsers)
                {
                    Console.WriteLine(user);
                }

                // SortedList
                SortedList<int, string> sortedListUsers = new SortedList<int, string>();

                sortedListUsers.Add(30, "Ahmet Yılmaz");
                sortedListUsers.Add(10, "Mert Yılmaz");
                sortedListUsers.Add(20, "Mehmet Yılmaz");

                foreach (var user in sortedListUsers)
                {
                    Console.WriteLine(user);
                }

                // loop only values
                foreach (var user in sortedListUsers.Values)
                {
                    Console.WriteLine(user);
                }

                // loop only keys
                foreach (var user in sortedListUsers.Keys)
                {
                    Console.WriteLine(user);
                }

                // removeAt
                sortedListUsers.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
                Thread.Sleep(3000);
            }
        }
    }
        
}