namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();

            users = ...;// Получаем список пользователей.

            for (int i = 0; i < users.Count; i++) 
            {
                Console.WriteLine($"Здравствуйте {users[i].Name}");

                if (!users[i].IsPremium)
                    ShowAds();
            }
        }
    }
}
