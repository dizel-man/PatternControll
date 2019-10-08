using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//запуск команд
public class InputManager : MonoBehaviour
{
    private string pressedKey;
    public bool useKeyDebug = false;

    //  public KeyCode _fire = KeyCode.Space;

    public string _fire = "Space";
    public string _light = "L";
    public string _jump = "J";
    public string _sound = "S";
    public string _ball = "B";

    InputControll inputCtrl = new InputControll();



    void Start()
    {
        // назначение ключу свою команду через методы в InputControll скрипте
        inputCtrl.SetCommandForButton(_fire, new FireCommand());
        inputCtrl.SetCommandForButton(_light, new SwitchLightsCommand(new Light()));
        inputCtrl.SetCommandForButton(_jump, new JumpCommand());
        inputCtrl.SetCommandForButton(_sound, new SoundCommand());
        inputCtrl.SetCommandForButton(_ball, new BallCommand());


    }


    void Update()
    {
        DetectPressedKey();

    }



    //keyboard
    public void DetectPressedKey()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                if (useKeyDebug)
                {
                    Debug.Log("KeyCode down: " + kcode);
                }

                pressedKey = kcode.ToString();
               

                inputCtrl.PushButton(pressedKey);

               
            }

        }
    }

    //ui buttons
    public void DetectPressedButton(string bottonCommand)
    {
      
        inputCtrl.PushButton(bottonCommand);

        if (useKeyDebug)
        {
            Debug.Log("KeyCode down: " + bottonCommand);
        }

        // after pressing the button, it is stay active this method turn it off
        EventSystem.current.SetSelectedGameObject(null);
    }

    

}
