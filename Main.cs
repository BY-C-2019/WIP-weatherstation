using System;
using System.Collections.Generic;
namespace weatherstation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listor för stad och temperatur
            List<string> citys=new List<string>();
            List<double> temp=new List<double>();
            List<string> nice=new List<string>();

            //Deklarerade variabler
            string city;
            double temperatur;
            double AverageTemp=0;

            //Loop för menyn
            while(true){
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Tryck på enter för att komma till menyn!");
                Console.ReadKey();
                Console.Clear();
            Console.WriteLine("[L]ägg till temperaturmätning");
            Console.WriteLine("[S]kriv ut alla temperaturer och medeltemperaturen");
            Console.WriteLine("[T]a bort temperaturmätning");
            Console.WriteLine("[A]vsluta");
            try{
            char answer=Convert.ToChar(Console.ReadLine());

                if(answer=='L'||answer=='l'){
                    Console.Clear();
                    Console.Write("Stad:");
                    city=Console.ReadLine();

                    Console.Write("Ange temperatur för "+city+":");
                    try{
                    temperatur=Convert.ToDouble(Console.ReadLine());

                    //Lägger till värden i listor och variabler
                    AverageTemp+=temperatur;
                    citys.Add(city);
                    temp.Add(temperatur);
                    nice.Add(city+": "+temperatur);
                    } catch{
                        Console.Clear();
                        Console.WriteLine("Felinmatning!");
                    }
                } else if (answer=='S'|| answer=='s'){
                    Console.Clear();
                    for(int i=0;i<nice.Count;i++){
                        Console.WriteLine(nice[i]);
                        
                    }
                    //Räknar ut medeltemperaturen och skriver ut avrundat till två decimaler
                    Console.WriteLine("Medeltemperaturen är: "+Math.Round(AverageTemp/temp.Count, 2));
                } else if(answer=='T'||answer=='t'){
                    Console.Clear();
                    for(int i=0;i<nice.Count;i++){
                        Console.WriteLine((i+1)+":"+nice[i]);
                        
                    }
                    Console.WriteLine("-------------------------");
                    Console.Write("Välj nummret på den staden du vill ta bort:");
                    try{
                    int remove=Convert.ToInt32(Console.ReadLine());
                    
                    //Tar bort värden från listor och variabler
                    AverageTemp-=(temp[remove-1]);
                    nice.RemoveAt(remove-1);
                    citys.RemoveAt(remove-1);
                    temp.RemoveAt(remove-1);
                    }catch{
                        Console.WriteLine("Felinmatning");
                    }
                } else if(answer=='A'||answer=='a'){
                break;
                } else{
                    Console.Clear();
                Console.WriteLine("Du måste ange en bokstav!");
                }
            } catch{
                Console.Clear();
                Console.WriteLine("Du måste ange en bokstav!");
            }
            }
        }
    }
}
