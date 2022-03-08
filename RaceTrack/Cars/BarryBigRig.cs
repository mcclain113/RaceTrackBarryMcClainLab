using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class BarryBigRig : RaceCar
    {
        public BarryBigRig()
        {
            Name = "Barry's Big Rig";
            TopSpeed = 85;
        }
        
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!");
        }
        
        public virtual void Brake()
        {
            Console.WriteLine($"The world's greatest truck {Name} ends in position {Position}!");
        }
    }
}