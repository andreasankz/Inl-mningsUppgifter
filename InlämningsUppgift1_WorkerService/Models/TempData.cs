using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace InlämningsUppgift1_WorkerService.Models
{
    class TempData
    {
        public class Main
        {
            public double Temp { get; set ; }
            public int Humidity { get; set; }
        }


        public class Root
        {
            public string Name { get; set; }
            public Main Main { get; set; }
        }
        
        
        
        
        
        
        
        
        
        
        
       /* public int Temperatur { get => TempRandom(); }
          private int TempRandom()
          {
             Random tempSlump = new Random();
             int rTemperatur = tempSlump.Next(1, 31);
             return rTemperatur;
          }
       */
    }
}
