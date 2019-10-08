using UnityEngine;

public class SwitchLightsCommand : ICommand
{

    private Light _light;

    public SwitchLightsCommand(Light ligth)
    {
        _light = ligth;
    }


   public void Execute()
    {

        switch (_light.state)
        {
            case Light.State.Off:
                _light.TurnOn();
                break;
            case Light.State.On:
               
                _light.TurnOff();
                break;
            default:
                break;
        }

    }

   
}
