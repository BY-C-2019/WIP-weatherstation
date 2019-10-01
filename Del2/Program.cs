using System;
using System.Collections.Generic;
namespace Del2
{
    class Program
    {   static List<string[]> stations =new List<string[]>();
        static string[] städer = new string[]{"Göteborg","Malmö","New York","London","Berlin"};

        static void Main(string[] args)
        {  
            foreach (var item in städer)
            {   string[] st = new string[2]{"",""};
                st[0] = item;
                st[1]="20";
                stations.Add(st);
            }
            
           
            bool avsluta = true ;
            while(avsluta)
            {
            Console.Clear();
             Console.WriteLine("Välkommen till Väderstationen!\n"+
             "[1] Lägg till en ny mätning.\n"+
             "[2] Visa Temperaturer.\n"+
             "[3] Redigera mätning.\n"+
             "[4] Visa medeltemperatur och Hi/Low");
              try
              {
                  string val = Console.ReadLine();
                  switch(val)
                  {
                      case "1":
                        AddTemp();
                            break;
                        case"2":
                        ListItems();
                            break;
                        case "3":
                        ChangeTemp();
                            break;
                         case"4":
                        ShowAvarageTemp();
                            break;   

                  }





              }
              catch (System.Exception)
              {
                  
                  throw;
              }  

            }
           void AddTemp()
           {
                        string[] station = new string[2]{"",""};
                        Console.Write("Skriv in stadens namn:");
                        station[0] = Console.ReadLine();
                        Console.WriteLine("Skriv in mätning: ");
                        if(Int32.TryParse(Console.ReadLine(),out int temp))
                        {
                            station[1]=Convert.ToString(temp);
                             stations.Add(station);
                        }
                        else
                        {   Console.WriteLine("Du matade inte in en siffra");
                            return;
                        }

                       
                        
           }
           void ListItems()
           {    
               
                        foreach (string[] item in stations)
                        {       int index = stations.IndexOf(item);

                                Console.WriteLine("Index["+index+"] Stad: "+item[0]+" Temp: "+item[1]);
                            
                             
              
                        }
                        Console.ReadLine();
           }
           void ChangeTemp()
           {
                foreach (string[] item in stations)
                        {       int index = stations.IndexOf(item);

                                Console.WriteLine("Index["+index+"] Stad: "+item[0]+" Temp: "+item[1]);
                            
                             
              
                        }

                        Console.Write("På vilket index vill du ändra temperaturen? ");
                        
                        if(Int32.TryParse(Console.ReadLine(),out int input))
                        {

                                
                                Console.Write("Skriv in ny temperatur: ");
                                foreach (string[] item in stations)
                                {       int index = stations.IndexOf(item);
                                        
                                       
                                            if(index==input)
                                            {
                                               
                                                for (int i = 0; i < item.Length; i++)
                                                {   
                                                    if(Int32.TryParse(Console.ReadLine(),out int temp))
                                                    {
                                                       item[1]=Convert.ToString(temp);
                                                       break;
                                                    }
                                                    else
                                                    {   
                                                        Console.WriteLine("Du matade inte in en siffra");
                                                        return;
                                                    }
                                                         

                                                }    
                                                     
                                            }

                                }
                             
                        }
                        else
                        {
                              Console.WriteLine("Du matade inte in en siffra");
                              return;
                        }
               
                    
           }
        
            void ShowAvarageTemp()
            {       
                    double avTemp =0;
                    int antal=0;
                    foreach (var item in stations)
                    {
                       
                        
                        avTemp+=Convert.ToDouble(item[1]);


                    }
                    for (int i = 0; i < stations.Count; i++)
                    {
                        antal =i;
                    }
                    double summa = avTemp/antal;
                    Console.WriteLine(avTemp);
                    Console.WriteLine("Medeltemperaturen är "+ summa.ToString("0.00")+" grader!");
                   
                    Console.ReadLine();
            }
        //TODO
         void Sort()
         {
                    double[] temperatur = new double[stations.Count];
                    double avTemp =0;
                    int antal=0;
                    foreach (var item in stations)
                    {
                       
                       
                        for (int i = 0; i < temperatur.Length; i++)
                        {
                            
                            temperatur[i] = Convert.ToDouble(item[1]);
                        }

                       


                    }
                    
                    bool sorteras=true;
                    for (int i = 0; i < temperatur.Length-1 && sorteras; i++)
                    {
                        sorteras = false;
                        for (int j = 0; j < temperatur.Length-1 -i; j++)
                        {
                            if(temperatur[j] >temperatur[j+1] )
                            {
                                sorteras = true;
                                double temp=  temperatur[j+1];
                                temperatur[j+1] =temperatur[j];
                                temperatur[j] = temp;
                            }
                        }

                    }
                    foreach (var item in temperatur)
                    {
                        Console.WriteLine(item);
                    }
                    //Console.WriteLine("Kallast temperatur är "+temperatur[0] + "och varmast är " +temperatur[stations.Count]);


         }

        }
    }
}
