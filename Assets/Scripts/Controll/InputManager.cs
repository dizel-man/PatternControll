using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//запуск команд
public class InputManager : MonoBehaviour
{
    private string pressedKey;
   
    //  public KeyCode _fire = KeyCode.Space;

    public string _fire = "Space";
    public string _light = "L";
    public string _jump = "J";
    public string _sound = "S";
    public string _ball = "B";
    public string _macro = "M";

    InputControll inputCtrl = new InputControll();



    void Start()
    {
        // назначение ключу свою "команду" через методы в InputControll скрипте 
        //run
        inputCtrl.SetCommandForButton(_fire, new FireCommand());
        inputCtrl.SetCommandForButton(_jump, new JumpCommand());
        inputCtrl.SetCommandForButton(_sound, new SoundCommand());
        inputCtrl.SetCommandForButton(_ball, new BallCommand());
        //run switch
        inputCtrl.SetCommandForButton(_light, new SwitchLightsCommand(new Light()));
       
        //macrocommand
        //creating macrocommand
        var ballCommand = new BallCommand();
        var soundCommand = new SoundCommand();
        //merging
        var macroCommand = new MacroCommand(new List<ICommand> { ballCommand, soundCommand });
        //run macrocommand
        inputCtrl.SetCommandForButton(_macro, macroCommand);


    }


    void Update()
    {
        DetectDownKey();

    }



    //keyboard down
    public void DetectDownKey()
    {
        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
              

                pressedKey = kcode.ToString();
               

                inputCtrl.PushButton(pressedKey);

               
            }

        }
    }

    //ui buttons
    public void DetectPressedButton(string bottonCommand)
    {
      
        inputCtrl.PushButton(bottonCommand);

        // after pressing the button, it is stay active this method turn it off
        EventSystem.current.SetSelectedGameObject(null);
    }

    

}
