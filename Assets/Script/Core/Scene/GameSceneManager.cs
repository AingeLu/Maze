/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: GameSceneManager
** 应  用: 场景切换管理器

**************************** 修改记录 *******************************
** 修改人:
** 日  期:
** 描  述:
********************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UIFramework;

public class GameSceneManager : MonoBehaviour
{   
    // 单例模式
    private static GameSceneManager m_Instance;
    public static GameSceneManager Instance
    {
        get { return m_Instance; }
    }

    private SceneType m_CurSceneType = SceneType.None;
    private string m_CurSceneName = SceneNameDef.SceneNone;

    private Coroutine m_SceneCoroutine = null;

    void Awake()
    {
        m_Instance = this;
    }

    void OnDestory()
    {
        m_Instance = null;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene(SceneType toSceneType, string toSceneName, bool additive = false)
    {
        LoadLoadingScene(toSceneName);

        m_SceneCoroutine = StartCoroutine(LoadSceneAsync(toSceneType, toSceneName, additive));
    }

    /// <summary>
    /// 进入加载场景
    /// </summary>
    /// <param name="toSceneName"></param>
    private void LoadLoadingScene(string toSceneName)
    {
        SceneManager.LoadScene(SceneNameDef.SceneLoading);

        m_CurSceneType = SceneType.LOADING;
        m_CurSceneName = SceneNameDef.SceneLoading;

        Singleton<ContextManager>.Instance.Push(new LoadingContext("loading " + toSceneName));
    }

    /// <summary>
    /// 异步加载场景
    /// </summary>
    /// <param name="toSceneType"></param>
    /// <param name="toSceneName"></param>
    /// <param name="additive"></param>
    /// <returns></returns>
    private IEnumerator LoadSceneAsync(SceneType toSceneType, string toSceneName, bool additive)
    {
        yield return new WaitForSeconds(1f);

        if (additive)
        {
            AsyncOperation asyncOp = SceneManager.LoadSceneAsync(toSceneName, LoadSceneMode.Additive);

            yield return asyncOp;
        }
        else
        {
            AsyncOperation asyncOp = SceneManager.LoadSceneAsync(toSceneName);

            yield return asyncOp;
        }

        m_CurSceneType = toSceneType;
        m_CurSceneName = toSceneName;

        yield return LoadSceneEnd(toSceneType, toSceneName);
    }

    /// <summary>
    /// 加载启动场景
    /// </summary>
    private IEnumerator LoadStartScene(SceneType toSceneType, string toSceneName, bool additive)
    {
        yield return 0f;
    }

    /// <summary>
    /// 切换到登录场景
    /// </summary>
    private IEnumerator LoadLoginScene(SceneType toSceneType, string toSceneName, bool additive)
    {
        yield return 0f;
    }

    /// <summary>
    /// 加载场景完成
    /// </summary>
    /// <param name="toSceneType"></param>
    /// <param name="toSceneName"></param>
    /// <returns></returns>
    private IEnumerator LoadSceneEnd(SceneType toSceneType, string toSceneName)
    {
        Singleton<ContextManager>.Instance.Clear();
        Singleton<UIManager>.Instance.Clear();

        switch (toSceneType)
        {
            case SceneType.None:
                break;
            case SceneType.START:
                Singleton<ContextManager>.Instance.Push(new StartContext());
                break;
            case SceneType.LOGIN:
                Singleton<ContextManager>.Instance.Push(new LoginContext());
                break;
            case SceneType.LOBBY:
                Singleton<ContextManager>.Instance.Push(new LobbyContext());
                break;
            case SceneType.LOADING:
                break;
            default:
                break;
        }

        yield return 1;
    }
}
