using System.Text;
using UnityEngine;

namespace stroitel
{
    public class Car 
    {
        public string Engine { get; set; }
        public string Frame { get; set; }
        public string Wheel { get; set; }
        public string Luxory { get; set; }
        public string Multimedia { get; set; }
        public string Safety { get; set; }

        public override string ToString()
        {
          
            var sb = new StringBuilder();
            sb.AppendFormat("Frame: {0}\n", Frame);
            sb.AppendFormat("Engine: {0}\n", Engine);
            sb.AppendFormat("Wheels: {0}\n", Wheel);
            sb.AppendFormat("Multimedia: {0}\n", Multimedia);
            sb.AppendFormat("Safety: {0}\n", Safety);
            sb.AppendFormat("Luxory: {0}\n", Luxory);

            return base.ToString();

        }

    }
}

