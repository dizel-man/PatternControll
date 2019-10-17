using UnityEngine;

namespace stroitel
{
     class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder() : base()
        {

        }

        public override void BuildEngine()
        {
            car.Engine = "1.8 TSI";
        }

        public override void BuildFrames()
        {
            car.Frame = "VW frame";
        }

        public override void BuildLuxury()
        {
            car.Luxory = "VW R-Style";
        }

        public override void BuildMultimedia()
        {
            car.Multimedia = "VW RNS 510";
        }

        public override void BuildSafety()
        {
            car.Safety = "VW Lane Assist";
        }

        public override void BuildWheels()
        {
            car.Wheel = "17 Wheel";
        }
    }

}
