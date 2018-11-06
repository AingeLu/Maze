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
    }

	// Use this for initialization
	void Start ()
    {
        Singleton<UIManager>.Create();
        Singleton<ContextManager>.Create();
        Singleton<Localization>.Create();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
