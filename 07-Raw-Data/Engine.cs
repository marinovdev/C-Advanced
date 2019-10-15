using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Raw_Data
{

    public class Engine
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
