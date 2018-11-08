using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Interfaces;
using PureMVC.Patterns.Facade;

//Facade模式的单例
public class AppFacade : Facade
{
    //实例化函数，保证单例模式(Singleton)运行该函数
    public new static IFacade Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.Log("ApplicationFacade");
                instance = new AppFacade();
            }
            return instance;
        }
    }

    //启动PureMVC的入口函数
    public void Startup(Main main)
    {
        Debug.Log("Startup() to SendNotification.");
        SendNotification(EventsEnum.STARTUP, main);
    }

    //该类的构造器
    protected AppFacade()
    {

    }

    //设置静态
    static AppFacade()
    {

    }
    
    //初始化控制器函数
    //创建Commond，并注册。
    protected override void InitializeController()
    {
        Debug.Log("InitializeController()");
        base.InitializeController();

        RegisterCommand(EventsEnum.STARTUP, () => new StartupCommand());
        RegisterCommand(NotifyConst.S_LOGIN, () => new LoginCommand());
    }
}
