using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Operations
    {
        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string School { get; set; }
            public int SuspensionCount { get; set; }

            public Person(int id, string name, int age, string school) 
            {
                Id = id;
                Name = name;
                Age = age;
                School = school;
                SuspensionCount = 0;
            }

            public override string ToString()
            {
                return $"Student ID: {Id}, Name: {Name}, Age: {Age}, School: {School}, Suspension Count: {SuspensionCount}";
            }

        }

        public class PersonsList
        {
            public List<Person> List { get; set; }
            public List<Person> Suspended { get; set; }

            public PersonsList()
            {
                this.List = new List<Person>();
                this.Suspended = new List<Person>();
            }

            public void AddPerson(int id, string name, int age, string school)
            {
                Person person = new Person(id, name, age, school);
                this.List.Add(person);

                Console.WriteLine("\nUpdated Lists after Adding Person: ");
                displayLists();
            }

            public void SuspendPerson(int id)
            {
                if (List.Count == 0)
                {
                    Console.WriteLine("There is currently no student in the list.");
                    return;
                }
                bool found = false;
                for(int i=0; i<List.Count; ++i)
                {
                    if (List[i].Id == id)
                    {
                        found = true;
                        List[i].SuspensionCount++;
                        Suspended.Add(List[i]);
                        this.List.RemoveAt(i);
                        Console.WriteLine($"Successfully Suspended Studen.");
                    }
                }
                if (found)
                {
                    Console.WriteLine("\nUpdated Lists after Unsuspending Person: ");
                    displayLists();
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            public void UnsuspendPerson(int id)
            {
                if(Suspended.Count == 0)
                {
                    Console.WriteLine("There is currently no suspended student.");
                    return;
                }
                bool found = false;
                for (int i = 0; i < Suspended.Count; ++i)
                {
                    if (Suspended[i].Id == id)
                    {
                        found=true;
                        List.Add(Suspended[i]);
                        this.Suspended.RemoveAt(i);
                    }
                }

                if (found)
                {
                    Console.WriteLine("\nUpdated Lists after Unsuspending Person: ");
                    displayLists();
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }

                
            }

            public void displayLists()
            {
                if (List.Count() > 0)
                {
                    Console.WriteLine("List of Students: ");
                    foreach (Person person in this.List)
                    {
                        Console.WriteLine(person.ToString());
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("There is currently no students in the list.");
                }

                if (Suspended.Count() > 0)
                {
                    Console.WriteLine("List of Suspended Students: ");
                    foreach (Person person in this.Suspended)
                    {
                        Console.WriteLine(person.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("There is currently no suspended students.");
                }
                
            }

            public void displayNumbers()
            {
                Console.WriteLine($"List of Students: {List.Count()}");
                Console.WriteLine($"List of Suspended Students: {Suspended.Count()} ");
            }
        }
    }
}
