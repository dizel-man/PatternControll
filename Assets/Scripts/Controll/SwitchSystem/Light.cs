using UnityEngine;


public class Light
{
      public enum State
    {
        Off = 0,
        On = 1
    }
    public State state { get; set; }


    public void TurnOn()
    {
        Debug.Log("light is On");
        state = State.On;
    }

    public void TurnOff()
    {
        Debug.Log("light is Off");
        state = State.Off;
    }
}
