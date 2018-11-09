using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFramework;

public class StartContext : BaseContext
{
    public StartContext()
        : base(UIType.Start)
    {

    }
}

public class StartView : AnimateView
{

    private Coroutine m_Coroutine = null;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public override void OnEnter(BaseContext context)
    {
        base.OnEnter(context);

        m_Coroutine = StartCoroutine(CoroutineEnumerator());
    }

    public override void OnExit(BaseContext context)
    {
        base.OnExit(context);

        if (m_Coroutine != null)
        {
            StopCoroutine(m_Coroutine);
            m_Coroutine = null;
        }
    }

    public override void OnPause(BaseContext context)
    {
        _animator.SetTrigger("OnExit");
    }

    public override void OnResume(BaseContext context)
    {
        _animator.SetTrigger("OnEnter");
    }

    private IEnumerator CoroutineEnumerator()
    {
        yield return new WaitForSeconds(2f);

        GameSceneManager.Instance.ChangeScene(SceneType.LOGIN, SceneNameDef.SceneLogin);
    }
}
