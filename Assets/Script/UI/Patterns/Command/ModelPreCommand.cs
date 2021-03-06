﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns.Command;

// 创建Proxy，并注册。
public class ModelPreCommand : SimpleCommand
{
    public override void Execute(PureMVC.Interfaces.INotification notification)
    {
        Debug.Log("ModelPreCommand.Execute()");
        Facade.RegisterProxy(new UserProxy());
        Facade.RegisterProxy(new LoginProxy());
    }
}