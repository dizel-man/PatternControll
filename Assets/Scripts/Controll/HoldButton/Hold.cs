using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class Hold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ICommand
{
   public bool hold = false;


    public void OnPointerDown(PointerEventData eventData)
    {
        hold = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        hold = false;
    }

    public void Update()
    {
        Execute();
    }

    public void Execute()
    {
        if (hold)
        {
            Debug.Log("hold fire");
        }
       
    }

}
