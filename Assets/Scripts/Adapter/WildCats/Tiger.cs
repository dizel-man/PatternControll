using UnityEngine;

namespace adapter
{
    public class Tiger : IWildCat
    {
        public string Breed { get { return "Тигр обыкновенный"; } }



        public void Glowl()
        {
            Debug.Log("Grrrrr");
        }

        public void Scratch()
        {
            Debug.Log("Очень острые когти");
        }
    }

}


