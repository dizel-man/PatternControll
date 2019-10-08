using UnityEngine;

public class FireCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("This is FireCommand ");
    }

    
    
}