using UnityEngine;

public class SoundCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("This is SoundCommand ");
    }

    public void Undo()
    {

    }

    //public override string ToString()
    //{
    //    // return base.ToString();
    //    return "sound on";
    //}
}