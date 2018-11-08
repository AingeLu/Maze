using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PureMVC.Patterns.Mediator;
using PureMVC.Interfaces;

public class LoginViewMediator : Mediator, IMediator
{
    public const string NAME = "LoginMediator";

    public LoginViewMediator(LoginView _view)
        : base(NAME, _view)
    {

    }

    //需要监听的消息号
    public override string[] ListNotificationInterests()
    {
        List<string> list = new List<string>();
        list.Add(NotifyConst.R_LOGIN);
        return list.ToArray();
    }

    //接收消息到消息之后处理
    public override void HandleNotification(PureMVC.Interfaces.INotification notification)
    {
        string name = notification.Name;
        object vo = notification.Body;
        switch (name)
        {
            case NotifyConst.R_LOGIN:
                (this.ViewComponent as LoginView).receiveMessage(vo);
                break;
        }
    }
}