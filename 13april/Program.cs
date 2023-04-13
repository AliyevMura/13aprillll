using Task13april.Personclass;
namespace Task13april
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "M";
            person.Surname = "Aliyev";
            person.Age = 19;
            person.Birthday = 1969;
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Surname);
            Console.WriteLine(person.Birthday);
        }
    }
}