using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fac
{
    public class RunFactoryObject : MonoBehaviour
    {

        Factory creatorA;
        Factory creatorB;

        Product productA;
        Product productB;

        public bool A = false;
        public GameObject obj_A;
        [Space(5)]
        public bool B = false;
        public GameObject obj_B;

        void Start()
        {
            CreateObj();
        }

        
        void CreateObj()
        {
            if (A)
            {
                creatorA = new ConcreteFactoryA();
                productA = creatorA.FactoryMethod();
                GameObject a = productA.GetObject(obj_A);
                a.transform.SetParent(this.transform);
                a.name = obj_A.name;

            }

            if (B)
            {
                creatorB = new ConcreteFactoryB();
                productB = creatorB.FactoryMethod();
                GameObject b = productB.GetObject(obj_B);
                b.transform.SetParent(this.transform);
                b.name = obj_B.name;
            }
           

        }
    }

}
