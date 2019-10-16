using UnityEngine;

namespace Factory
{
    public class Golf : Car
    {
        private CarPartsFactory _factory;

        public Golf(CarPartsFactory factory)
        {
            _factory = factory;
            Name = "Golf";
            Body = "HatchBack";

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


