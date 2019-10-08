using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControll
{


    private Dictionary<string, ICommand> _commands;

    //конструктор для создания(добавления Add) множество коллекций типа _commands.Add("fire", new FireCommand());
    public InputControll()
    {

        _commands = new Dictionary<string, ICommand>();

      

        foreach (var BtnId in _commands.Keys)
        {

            _commands.Add(BtnId, _commands[BtnId]);
        }

    }


    

    public void PushButton(string buttonId)
    {
       // buttonId = "" ?? string.Empty;
        if (_commands.ContainsKey(buttonId))
        {
            _commands[buttonId].Execute();
        }

     
    }

    //public void UndoButton(string buttonId)
    //{
    //    if (_commands.ContainsKey(buttonId))
    //    {
    //        _commands[buttonId].Undo();
    //    }
    //}

    //назначить ключ в словарь к интерфейсу без всяких проверок
    //тут если ключ не существует он будет добавлен в словарь
    //а если существует то будет переписан
    public void SetCommandForButton(string buttonID, ICommand cmd)
    {
        _commands[buttonID] = cmd;
    }


 


}
