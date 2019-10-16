
using UnityEngine;

namespace Factory
{

    public class Passat : Car
    {
        private CarPartsFactory _factory;

        public Passat(CarPartsFactory factory)
        {
            _factory = factory;
            Name = "Passat";
            Body = "Sedan";

        }

        public override void Configure()
        {
            Debug.Log("Name: " + Name);
            Debug.Log("Body: " + Body);

            Engine = _factory.CreateEngine();
            PaintColor = _factory.CreatePaints();
            Wheels = _factory.CreateWheels();
        }
    }

}
