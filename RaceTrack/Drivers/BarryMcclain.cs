using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BarryMcclain : Driver
    {
        public BarryMcclain(RaceCar car) : base(car)
        {
            Name = "Barry McClain";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}