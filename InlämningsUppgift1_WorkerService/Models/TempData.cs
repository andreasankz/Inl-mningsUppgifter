using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace InlämningsUppgift1_WorkerService.Models
{
    class TempData
    {
        public int Temperatur { get => TempRandom(); }

        
        
        private int TempRandom()
        {
            Random tempSlump = new Random();
            int rTemperatur = tempSlump.Next(1, 31);
            return rTemperatur;
        }

    }
}
