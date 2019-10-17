using UnityEngine;


namespace stroitel
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base()
        {

        }

        public override void BuildEngine()
        {
            car.Engine = " Audi 1.8 TSI - Engine";
        }

        public override void BuildFrames()
        {
            car.Frame = "Audi frame";
        }

        public override void BuildLuxury()
        {
            car.Luxory = "Audi R-Style";
        }

        public override void BuildMultimedia()
        {
            car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuildSafety()
        {
            car.Safety = "Audi Lane Assist";
        }

        public override void BuildWheels()
        {
            car.Wheel = "Audi 17 Wheel";
        }
    }
}


