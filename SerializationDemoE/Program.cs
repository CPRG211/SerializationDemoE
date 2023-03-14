using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace SerializationDemoE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writing (serialization):

            Student student1 = new Student("Joe Blow", 3.65, "password");
            Student student2 = new Student("John Smith", 2.5, "secret");
            Student student3 = new Student("Joe Schmoe", 3.9, "idaho");

            /*FileStream fileStream = new FileStream("students.bin", FileMode.Truncate);

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, student1);
            binaryFormatter.Serialize(fileStream, student2);
            binaryFormatter.Serialize(fileStream, student3);

            fileStream.Close();

            Console.WriteLine("Saved object to file");*/

            // Writing (JSON):
            /*FileStream fileStream = new FileStream("students.json", FileMode.OpenOrCreate);

            Student[] students = new Student[] { student1, student2, student3 };

            JsonSerializer.Serialize(fileStream, students);

            fileStream.Close();*/

            // Reading (serialization):
            /*FileStream fileStreamRead = File.OpenRead("students.bin");

            BinaryFormatter formatter = new BinaryFormatter();

            while (fileStreamRead.Position < fileStreamRead.Length)
            {
                Student student = (Student)formatter.Deserialize(fileStreamRead);

                Console.WriteLine(student.Name);
            }
            
            fileStreamRead.Close();*/
        }
    }
}