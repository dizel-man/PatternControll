using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace composite
{
    public class Composite : IShape
    {
        private List<IShape> components = new List<IShape>();


    public void addComponent(IShape component)
        {
            components.Add(component);
        }

     public   void removeComponent(IShape component)
        {
            components.Remove(component);
        }


        public override void Draw()
        {
            foreach (var comp in components)
            {
                comp.Draw();
            }
        }


    }
}


