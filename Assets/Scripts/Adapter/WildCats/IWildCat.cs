using UnityEngine;

namespace adapter
{
    interface IWildCat
    {
        string Breed { get; }//порода дикой кошки
        void Glowl();//рычание
        void Scratch();//царапание
    }

}

