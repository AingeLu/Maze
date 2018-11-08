using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFramework;

public class Main : MonoBehaviour
{
    void Awake()
    {
        //全局对象
        DontDestroyOnLoad(gameObject);

        Singleton<UIManager>.Create();
        Singleton<ContextManager>.Create();
        Singleton<Localization>.Create();

        //启动PureMVC程序，执行StartUP()方法
        AppFacade facade = AppFacade.Instance as AppFacade;
        facade.Startup(this);
    }

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
