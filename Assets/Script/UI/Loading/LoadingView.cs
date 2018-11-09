using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UIFramework;

public class LoadingContext : BaseContext
{
    public string m_StrText = string.Empty;
    public LoadingContext(string strText)
        : base(UIType.Loading)
    {
        m_StrText = strText;
    }
}

public class LoadingView : AnimateView
{
    public Text m_Text;

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

        LoadingContext loadingContext = (LoadingContext)context;
        m_Text.text = loadingContext.m_StrText;
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
}
