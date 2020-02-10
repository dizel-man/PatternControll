using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerHelper : NetworkBehaviour
{

    GameHelper _gameHelper;

    void Start()
    {
        _gameHelper = GameObject.FindObjectOfType<GameHelper>();
        if (isLocalPlayer)
            _gameHelper.CurrentPlayerHelper = this;
    }


   

    //[Command] значит этот метод вызывается только на сервере
    [Command]
    public void CmdSend( string msg)
    {
        Debug.Log("[command] Send " + msg);
        RpcSend(msg);
    }


    // [ClientRpc] значит этот метод высылается всем клиентам
    [ClientRpc]
    public void RpcSend( string msg)
    {
        _gameHelper.textBlock.text += System.Environment.NewLine + msg;
    }

}
