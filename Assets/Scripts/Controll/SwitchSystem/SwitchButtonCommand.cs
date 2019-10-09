using UnityEngine;

public class SwitchButtonCommand : ICommand
{

    private Button _button;

    public SwitchButtonCommand(Button button)
    {
        _button = button;
    }


   public void Execute()
    {

        switch (_button.state)
        {
            case Button.State.Off:
                _button.TurnOn();
                break;
            case Button.State.On:

                _button.TurnOff();
                break;
            default:
                break;
        }

    }

   
}
