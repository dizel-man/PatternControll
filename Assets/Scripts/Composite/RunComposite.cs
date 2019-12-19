using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace composite
{

    public class RunComposite : MonoBehaviour
    {

        IShape square1 = new Square();
        IShape square2 = new Square();

        IShape triangle1 = new Triangle();
        IShape triangle2 = new Triangle();

        IShape Circle1 = new Circle();
        IShape Circle2 = new Circle();

        Composite composite1 = new Composite();
        Composite composite2 = new Composite();

        Composite composite = new Composite();



        void Start()
        {
            
            composite1.addComponent(square1);
            composite1.addComponent(Circle1);
            composite1.addComponent(triangle2);
        
            composite2.addComponent(square2);
            composite2.addComponent(Circle2);
            composite2.addComponent(triangle1);



            composite.addComponent(composite1);
            composite.addComponent(composite2);


            composite.Draw();


        }

        
        void Update()
        {

        }
    }

}
