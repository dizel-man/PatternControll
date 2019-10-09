using UnityEngine;

public class FireCommand : MonoBehaviour, ICommand
{
    public void Execute()
    {
        Debug.Log("This is FireCommand ");
        this.gameObject.transform.Translate(1, 0, 0);
    }
    
}