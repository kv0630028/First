using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Lobby;
    }

    private void ToGame()
    {
        Managers.Scene.LoadScene(Define.Scene.Game);

    }

    public override void Clear()
    {
        Debug.Log("LoginScene Clear!");
    }
}
