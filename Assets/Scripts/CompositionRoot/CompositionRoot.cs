using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionRoot : MonoBehaviour
{
    private static IMainScreen MainScreen;
    private static IPlayer Player;

    // e t c 

    // создаем новый GameObject и вешаем на него компанент MainScreen
    public static IMainScreen GetMainScreen()
    {
        if (MainScreen == null)
        {
            MainScreen = MonoExtensions.MakeComponent<MainScreen>();
        }

        return MainScreen;
    }

    // создаем новый GameObject и вешаем на него компанент Player
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
