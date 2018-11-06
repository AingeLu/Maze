using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFramework;

public class LoginContext : BaseContext
{
    public LoginContext()
        : base(UIType.Login)
    {

    }
}

public class LoginView : AnimateView
{
    public GameObject m_EnterGame;

	// Use this for initialization
	void Start ()
    {
        UIEventTriggerListener.Get(m_EnterGame).onClick = OnClickEnterGame;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public override void OnEnter(BaseContext context)
    {
        base.OnEnter(context);
    }

    public override void OnExit(BaseContext context)
    {
        base.OnExit(context);
    }

    public override void OnPause(BaseContext context)
    {
        _animator.SetTrigger("OnExit");
    }

    public override void OnResume(BaseContext context)
    {
        _animator.SetTrigger("OnEnter");
    }

    public void OnClickEnterGame(GameObject go)
    {
        GameSceneManager.Instance.ChangeScene(SceneType.LOBBY, SceneNameDef.SceneLobby);
    }

    public void receiveMessage(object obj)
    {
    
    }
}
