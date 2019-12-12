using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Fac
{
    public class RunFactoryObject : MonoBehaviour
    {

        Creator creatorA;
        Creator creatorB;

        Product productA;
        Product productB;


        void Start()
        {

            Init();

            productA.Make();
            productB.Make();

        }

       
        void Update()
        {

        }

        private void Init()
        {
            creatorA = new ConcreteCreatorA();
            creatorB = new ConcreteCreatorB();

            productA = creatorA.FactoryMethod();
            productB = creatorB.FactoryMethod();
        }
    }

}
