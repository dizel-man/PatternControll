using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionRoot : MonoBehaviour
{
    private static IMainScreen MainScreen;
    private static IPlayer Player;

    // e t c 

    public static IMainScreen GetMainScreen()
    {
        if (MainScreen == null)
        {
            MainScreen = MonoExtensions.MakeComponent<MainScreen>();
        }

        return MainScreen;
    }


    public static IPlayer GetPlayer()
    {
        if (Player == null)
        {
            Player = MonoExtensions.MakeComponent<Player>();
        }

        return Player;
    }





    private void OnDestroy()
    {
        MainScreen = null;
        Player = null;

    }

}
