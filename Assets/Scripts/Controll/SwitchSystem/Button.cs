using UnityEngine;


public class Button
{
      public enum State
    {
        Off = 0,
        On = 1
    }
    public State state { get; set; }


    public void TurnOn()
    {
        Debug.Log("button is On");
        state = State.On;
    }

    public void TurnOff()
    {
        Debug.Log("button is Off");
        state = State.Off;
    }
}
