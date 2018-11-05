using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VersionManager : MonoBehaviour
{
    // 单例模式
    private static VersionManager m_Instance;
    public static VersionManager Instance
    {
        get { return m_Instance; }
    }

    private Coroutine m_DownCoroutine = null;

    private DownloadManager m_DownloadManager = null;

    void Awake()
    {
        m_Instance = this;
    }

    void OnDestory()
    {
        m_DownloadManager.OnDestroy();
        m_DownloadManager = null;

        m_Instance = null;
    }

	// Use this for initialization
	void Start ()
    {
        m_DownloadManager = new DownloadManager();
        m_DownloadManager.OnCreate();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void StartDownCoroutine()
    {
        m_DownloadManager.OnInit();
        m_DownCoroutine = StartCoroutine(m_DownloadManager.OnDownload());
    }

    public void StopDownCoroutine()
    {
        m_DownloadManager.OnUnInit();
        if (m_DownCoroutine != null)
        {
            StopCoroutine(m_DownCoroutine);
            m_DownCoroutine = null;
        }
    }
}
