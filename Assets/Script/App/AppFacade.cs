using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;
using PureMVC.Patterns.Facade;

public class AppFacade : Facade
{
    private static AppFacade _instance;
    public static AppFacade getInstance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AppFacade();
            }
            return _instance;
        }
    }

    protected override void InitializeController()
    {
        base.InitializeController();
        //RegisterCommand(EventsEnum.STARTUP, typeof(StartupCommand));
        //RegisterCommand(NotifyConst.S_LOGIN, typeof(LoginCommand));
    }

    public void startup()
    {
        SendNotification(EventsEnum.STARTUP);
    }
}
