using System;

namespace date_localization
{
    class Program
    {
        static void Main(string[] args)
        {
             System.Console.WriteLine("Fecha Y Hora: (yyyy - MM - dddd  Hora : minuto : segundo) \n");
        System.DateTime dateTyped =  System.DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("\nFecha Seleccionada:");
        System.Console.WriteLine(dateTyped);

        System.Console.WriteLine($"La fecha ingresada: {DateTime}");
            System.Console.WriteLine($"Fecha actual dos horas y 30 minutos despues: {DateTime.AddHours(2).AddMinutes(30)}");

            System.DateTime actualDate = System.DateTime.UtcNow;
            System.Console.WriteLine($"\nUTC Actual:  {actualDate}");

            System.Console.WriteLine("Fecha y hora en Beijing/Pekin");
            System.Console.WriteLine(TimeZoneInfo.ConvertTime(DateTime, TimeZoneInfo.FindSystemTimeZoneById("Beijing Standard Time")));


            if (dateTyped < System.DateTime.Now)  
            {
                TimeSpan timeDif = System.DateTime.Now - dateTyped;
                System.Console.WriteLine($"{timeDif.Days} dias transcurridos desde que se ingreso la fecha ");
            }
                
            else if (dateTyped == System.DateTime.Now) 
            {
                System.Console.WriteLine("{0:d} la fecha es actual", dateTyped);
            }
            else  
            {
                TimeSpan timeDif = dateTyped - System.DateTime.Now;

                System.Console.WriteLine($"{timeDif.Days} dias por transcurrir");
            }
        }
    }
}
