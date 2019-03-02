using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._2._19_H.W
{
   public class Camp
    {
        public int id { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get;  set; }
        public int NumberOfPeople { get;  set; }
        public int NumberOfTents { get;  set; }
        public int NumberOfFleshLights { get;  set; }
        private static int lastCampld = 0;

        public Camp(int latitude, int longitude, int numberOfPeople, int numberOfTents, int numberOfFleshLights)
        {
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLights;
            Camp.lastCampld++;
            this.id = Camp.lastCampld;
        }

        public override string ToString()
        {
            return $"Camp ID:{this.id,5}  Latitude{Latitude,5}  longitude{Longitude,5}  number of people:{NumberOfPeople,5}  number of tents{NumberOfTents,5}  number of flesh lights{NumberOfFleshLights}";
        }

        public static bool operator ==(Camp camp1,Camp camp2)
        {
            if (camp1.id == camp2.id)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(Camp camp1, Camp camp2)
        {
            return !(camp1.id == camp2.id);
        }
        public static bool operator >(Camp camp1, Camp camp2)
        {
            if (camp1.NumberOfPeople > camp2.NumberOfPeople)
            {
                return true;
            }
            else if (camp1.NumberOfPeople == camp2.NumberOfPeople)
            {
                Console.WriteLine("the same");
                return true;
            }
            else
                return false;
        }
        public static bool operator <(Camp camp1, Camp camp2)
        {
            return !(camp1.NumberOfPeople > camp2.NumberOfPeople);
        }
        public override bool Equals(object obj)
        {
            Camp otherCamp = obj as Camp;
            return this == otherCamp;
        }

        public override int GetHashCode()
        {
            return this.id;
        }
        public static Camp operator +(Camp camp1, Camp camp2)
        {
            return new Camp(camp1.Latitude + camp2.Latitude, camp1.Longitude + camp2.Longitude, camp1.NumberOfPeople + camp2.NumberOfPeople, camp1.NumberOfTents + camp2.NumberOfTents, camp1.NumberOfFleshLights + camp2.NumberOfFleshLights);
            
        }
        public Camp()
        {
                
        }
    }
}
