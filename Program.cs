using System;
using System.Collections.Generic;
using Exercise_inh_pp_abs.Entities;

namespace Exercise_inh_pp_abs {
    class Program {
        static void Main(string[] args) {
            List<Taxpayer> list = new List<Taxpayer>();
            double sum = 0;

            Console.Write("Enter the number of taxpayers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Taxpayer {i} data: ");
                Console.Write("Individual or company(I/C)? ");
                string ans = Console.ReadLine();
                if(ans.ToUpper() == "I") {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenses: ");
                    double healthExpenses = double.Parse(Console.ReadLine());

                    list.Add(new Individual(name, annualIncome, healthExpenses));
                } else {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                }

            }

            Console.Clear();

            Console.WriteLine("Taxpayers: \n");
            foreach (Taxpayer item in list) {
                Console.WriteLine(item.taxes());
                sum += item.Tax();
            }

            Console.WriteLine("\nTotal taxes: " + sum.ToString("F2"));
        }
    }
}
