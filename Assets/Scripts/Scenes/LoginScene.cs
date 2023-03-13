﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Login;
    }

    public void ToLobby()
    {        
            Managers.Scene.LoadScene(Define.Scene.Lobby );
     
    }

    public override void Clear()
    {
        Debug.Log("LoginScene Clear!");
    }
}
