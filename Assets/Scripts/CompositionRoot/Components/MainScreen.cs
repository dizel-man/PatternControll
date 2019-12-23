using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//будет появляться

public class MainScreen : MonoBehaviour , IMainScreen
{
    public void Show()
    {
        // View.Show();

        Debug.Log("this is MainScreen Show Method");
    }

    public void Hide()
    {
        // View.Hide();
    }
}
