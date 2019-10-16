using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace adapter
{
    public class AdapterRun : MonoBehaviour
    {
        IHomeCat vaska;
        IHomeCat wagner;
    
        void Start()
        {
            vaska = new YardCat();
            vaska.Name = "Васька";

            wagner = new PedigreedCat();
            wagner.Name = "Вагнер";

           CatInfoPrinter.PrintCatInfo(vaska);
           CatInfoPrinter.PrintCatInfo(wagner);

            //если таким же образом сделать тигра, у которого другой интерфейс
            //поэтому будет ошибка
            IWildCat tiger = new Tiger();
            //   CatInfoPrinter.PrintCatInfo(tiger);

            //после создания HomeCatAdapter создаём 
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatInfoPrinter.PrintCatInfo(adapter);

        }

 
    }

}

