namespace Assignments_2._3
{
    internal class Program
    {

        static void Main(string[] args)
        {
                string filePath = "Contact.txt";

                string name = "John Smith";
                int age = 20;
                string address = "1st Street";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Address: " + address);
                }

                Console.WriteLine("Reading details from the file:");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }           
        }
    }
}

