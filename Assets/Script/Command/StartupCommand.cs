using UnityEngine;
using System.Collections;
using PureMVC.Patterns.Command;

public class StartupCommand : MacroCommand
{
    protected override void InitializeMacroCommand()
    {
        //AddSubCommand(typeof(ModelPreCommand));
    }

}