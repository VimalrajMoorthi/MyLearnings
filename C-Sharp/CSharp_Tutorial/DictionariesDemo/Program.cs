using System;
using System.Runtime;

namespace DictionariesDemo
{
    class program
    {
        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora",32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artories", 55, 35),
                new Employee("Intern", "Ernest", 22, 8)
            };
            
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"}
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach (Employee employee in employees)
            {
                employeesDirectory.Add(employee.Role, employee);
            }

            // update item in dictionary
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key '{0}' was Updated!.", keyToUpdate);
            }
            else
            {
                Console.WriteLine("No employee found with the key {0}", keyToUpdate);
            }

            // remove item from dictionary
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role/Key '{0}' was Removed!.", keyToRemove);
            }
            else
            {
                Console.WriteLine("No employee found with the key '{0}'", keyToRemove);
            }


            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                // print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);
                // storing the value in an employee object
                Employee employee = keyValuePair.Value;
                // printing the properties of the employee object
                Console.WriteLine("Employee Name: {0}, Employee Role: {1}, Employee Age: {2}, Employee Salary: {3}", employee.Name, employee.Role, employee.Age, employee.Salary);
            }

            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Age: {2}, Salary: {3}", empl.Name, empl.Role, empl.Age, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this key {0}", key);
            }

            Employee result = null;
            // using TryGetValue() it returns true if the operation was successful and false otherwise
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Employee Name: {0}, Role: {1}, Age: {2}, Salary: {3}", result.Name, result.Role, result.Age, result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }
        }
    }

    class Employee
    {
        // few properties like Role, Name, Age and Rate

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly Salary = rate/h * number of days * number of weeks * number of months

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // simple constructor

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}