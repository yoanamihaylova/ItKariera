using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days;
            Days = int.Parse(Console.ReadLine());
            int Patients;
            int Doctors = 7;
            int Untreated = 0, Treated = 0;
            int AllU = 0,AllT = 0;
            for(int i=1;i<=Days;i++)
            {
                if (i % 3 == 0)
                {
                    if (Untreated > Treated) Doctors++;
                    Treated = 0;
                    Untreated = 0;
                }
                Patients = int.Parse(Console.ReadLine());
                if (Patients > Doctors) { Untreated = Patients - Doctors; Treated = Doctors; AllU += Untreated; AllT += Treated; }
                else { Treated = Patients; AllT += Treated; }
                
            }
            Console.WriteLine("Treated patients {0}.",AllT);
            Console.WriteLine("Untreated patients {0}.",AllU);
        }
    }
}
