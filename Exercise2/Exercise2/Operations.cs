using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise2
{
    internal class Operations
    {
        public class Computation
        {
            public double var1 { get; set; }
            public string operatorMath { get; set; }
            public double var2 { get; set; }
            public double result { get; set; }

            public string date;

            public Computation(double var1, string operatorMath, double var2)
            {
                this.var1 = var1;
                this.operatorMath = operatorMath;
                this.var2 = var2;
                this.date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            }
            public override string? ToString()
            {
                return $"{date} : {var1} {operatorMath} {var2} = {result} ";
            }

        }
        public class HistoryList
        {
            private List<Computation> history { get; set; }

            public HistoryList()
            {
                history = new List<Computation>();
            }

            public void Operate(double var1, string operatorMath, double var2)
            {
                Computation computation = new Computation(var1, operatorMath, var2);
                
                computation.result = 0;
                switch (operatorMath)
                {
                    case "/":
                        computation.result = var1 / var2;
                        break;
                    case "-":
                        computation.result = var1 - var2;
                        break;
                    case "*":
                        computation.result = var1 * var2;
                        break;
                    case "+":
                        computation.result = var1 + var2;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"{computation.result}\n");
                //Console.WriteLine($"{computation.date}: {var1} {operatorMath} {var2} = {computation.result} ");
                history.Add(computation);
            }

            public void ViewHistory()
            {
                string fileName = @"C:\Users\Jeskha\source\repos\Exercise2\Exercise2\History.txt";

                try
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    using (StreamWriter sw = File.CreateText(fileName))
                    {
                        foreach (Computation computation in history)
                        {
                            sw.WriteLine(computation.ToString());
                        }
                    }

                    // Write file contents on console.
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                }

                Console.WriteLine();

            }
        }
    }
}
