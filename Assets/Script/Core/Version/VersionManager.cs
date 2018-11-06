/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: GameSceneManager
** 应  用: 版本升级管理器

**************************** 修改记录 *******************************
** 修改人:
** 日  期:
** 描  述:
********************************************************************/

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
