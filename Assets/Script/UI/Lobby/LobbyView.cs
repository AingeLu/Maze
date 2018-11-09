using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFramework;

public class LobbyContext : BaseContext
{
    public LobbyContext()
        : base(UIType.Lobby)
    {

    }
}

public class LobbyView : AnimateView
{
    public GameObject m_EnterBattle;

	// Use this for initialization
	void Start ()
    {
        UIEventTriggerListener.Get(m_EnterBattle).onClick = OnClickEnterBattle;
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

    public void OnClickEnterBattle(GameObject go)
    {
    
    }
}
