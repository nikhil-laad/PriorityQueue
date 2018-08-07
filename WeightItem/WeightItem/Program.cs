using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightItem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin priority queue demo");
            Console.WriteLine("Creating priority queue of employee items");
            PriorityQueue<Employee> pq = new PriorityQueue<Employee>();

            //dmeo code here

            Console.WriteLine("End priority queue demo");
            Console.ReadLine();

        }
        static void TestPriorityQueue(int numOperations)
        {
            //Implementation code here
        }
    }

    public class Employee : IComparable<Employee>
    {
        public string lastName;
        public double priority;
        public Employee(string lastName, double priority)
        {
            this.lastName = lastName;
            this.priority = priority;
        }
        public override string ToString()
        {
            return "(" + lastName + "," + priority.ToString("F1") + ")";
        }
        public int CompareTo(Employee other)
        {
            if (this.priority < other.priority) return -1;
            else if (this.priority > other.priority) return 1;
            else return 0;
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;
        public PriorityQueue()
        {
            this.data = new List<T>();
        }
    }
}
