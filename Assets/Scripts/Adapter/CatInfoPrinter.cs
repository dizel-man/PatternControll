using UnityEngine;


// тут якобы код взятый из другого ПО и его нельзя менять (типо этого)
namespace adapter
{
    //если пишем public то ошибка
    class CatInfoPrinter
    {
       public static void PrintCatInfo(IHomeCat cat)
        {
            Debug.Log("кот: " + cat.Name);
            Debug.Log("мяуконие: ");
            cat.Meow();
            Debug.Log("царапание: ");
            cat.Scratch();
        
        }
    }
}


