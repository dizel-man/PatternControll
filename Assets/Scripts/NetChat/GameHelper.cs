using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//скрипт который отвечает за весь процесс


public class GameHelper : MonoBehaviour
{

    public InputField inputField;
    public Text textBlock;

    // GameHelper должен знать с каким игроком он
    // сейчас имеет дело поэтому
   private PlayerHelper _currentplayerHelper;

    public PlayerHelper CurrentPlayerHelper
    {
        get { return _currentplayerHelper; }
        set { _currentplayerHelper = value; }
    }

   

    public void Send()
    {
        CurrentPlayerHelper.CmdSend(inputField.text);
    }
}
