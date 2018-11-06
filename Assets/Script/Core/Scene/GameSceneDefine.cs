using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SceneType
{
    None,

    START,
    LOGIN,
    LOBBY,

    LOADING,
};

public class SceneNameDef
{
    public const string SceneNone = "";

    public const string SceneStart = "Start";
    public const string SceneLogin = "Login";
    public const string SceneLobby = "Lobby";

    public const string SceneLoading = "Loading";
}