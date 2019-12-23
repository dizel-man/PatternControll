using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    private IMainScreen MainScreen;
    private IPlayer player;

    private void Awake()
    {

        MainScreen = CompositionRoot.GetMainScreen();
        MainScreen.Show();

        player = CompositionRoot.GetPlayer();
        player.Hello();
       
    }
}
