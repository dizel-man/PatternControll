using UnityEngine;

public class JumpCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("This is JumpCommand ");
    }

   
}
