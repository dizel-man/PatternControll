using UnityEngine;

// упращенное выполнение - оптимизация
namespace ShablonniyMethod
{
    abstract class FastFood
    {
        public void Prepare()
        {
            RoastBread();
            PrepareMainIngridient();
            PutVegetables();
            AddTopings();
            Debug.Log("finish....");

        }

        //эти методы в в хот доге и в габургере делаются по-разному
        //сделали абстрактными чтобы обязать выполнения в дочерних классах
        // одинаковое название но внутри разная реализация
        public abstract void PrepareMainIngridient();
        public abstract void AddTopings();


        // ложить хлеб надо и в хот доге и в габургере
        public void RoastBread()
        {
            Debug.Log("Bread");
        }
        // ложить овощи надо и в хот доге и в габургере
        public void PutVegetables()
        {
            Debug.Log("Vegetables");
        }

    }
}



