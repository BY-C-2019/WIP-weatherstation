using System.Collections.Generic;
namespace Del2
{
    public class Stations
    {
        
        public string temp { get; set; }
        public string city { get; set; }



        public Stations(string Temp, string City)
        {
              temp = Temp;
              city = City;

                
        }
        public string SkrivUt()


        {
                return city + temp;
        }


    }
}