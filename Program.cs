using System;

namespace Music
{
    class Program
    {
        static void Main(string[] args)
        {
            Types types = new Types();
            HistoricPeriodics periodics = new HistoricPeriodics();
            foreach(string musicTypes in types.MusicTypes()){
                Console.WriteLine(musicTypes);
            };
            }
        }
    }
