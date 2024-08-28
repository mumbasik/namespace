

using System.Security.Cryptography.X509Certificates;
using USA;

namespace firstspace
{
class Text
    {
        public void Print()
        {
            Console.WriteLine("Hello from Namespace1");
        }
    }
}
namespace secondspace
{
    class Text
    {
        public void Print()
        {
            Console.WriteLine("Hello from Namespace2");
        }
    }
}
namespace Company
{
    namespace Departament { 
        class Employee
        {
            public void ShowDepartament()
            {
                Console.WriteLine("Employee belongs to Sales Department");
            }
        }
    
    }

}

namespace MathOperations
{
    class Operation
    {
        private int x { get; set; }
        private int y { get; set; }
        public Operation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Calculating ()
        {
            Console.WriteLine($"Result of + operation =   {this.x + this.y}");
        }
    }
}
namespace StringOperations
{
    class Operation
    {
        private string one { get; set; }
        private string two { get; set; }
        public Operation(string one, string two)
        {
            this.one = one;
            this.two = two;
        }
        public void Concatenetion () {
            Console.WriteLine("Result of concatenetion: " + this.one + this.two);
        }
    }
}
public interface City
{
    public int Count { get; }
}
namespace USA
{
    public class Washington :  City
    {
        public int Count { get; set; }
        public Washington(int count)
        {
            this.Count = count;
        }
    }
}
namespace Japan
{
    public class Tokyo: City
    {
        public int Count { get; set; }
        public Tokyo(int count)
        {
            this.Count = count;
        }
    }
}
namespace China
{
    public class Pekin : City
    {
        public int Count { get; set; }
        public Pekin(int count)
        {
            this.Count = count;
        }
    }
}

namespace namespace1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            firstspace.Text obj = new firstspace.Text();
            obj.Print();
            secondspace.Text obj2 = new secondspace.Text();
            obj2.Print();
            Company.Departament.Employee employee = new Company.Departament.Employee();
            employee.ShowDepartament();
            MathOperations.Operation obj3 = new MathOperations.Operation(1, 2);
            obj3.Calculating();
            StringOperations.Operation obj4 = new StringOperations.Operation("He", "llo");
            obj4.Concatenetion();
            City[] array = { new USA.Washington(671803),new Japan.Tokyo(13000000),new China.Pekin(21000000) };
            int max = array[0].Count;
            int min = array[0].Count;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Count > max)
                {
                    max = array[i].Count;
                    
                }
                if (array[i].Count < min)
                {
                    min = array[i].Count;
                }
            }
            Console.WriteLine($"Maximum population = {max}");
            Console.WriteLine($"Minimum population = {min}");



        }
    }
}

