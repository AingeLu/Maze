/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: 
** 应  用: Define View's Path And Name

**************************** 修改记录 *******************************
** 修改人:
** 日  期:
** 描  述:
********************************************************************/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UIFramework
{
	public class UIType {

        public string Path { get; private set; }

        public string Name { get; private set; }

        public UIType(string path)
        {
            Path = path;
            Name = path.Substring(path.LastIndexOf('/') + 1);
        }

        public override string ToString()
        {
            return string.Format("path : {0} name : {1}", Path, Name);
        }

        public static readonly UIType Start = new UIType("Prefab/View/Start/StartView");

        public static readonly UIType Loading = new UIType("Prefab/View/Loading/LoadingView");

        public static readonly UIType MainMenu = new UIType("Prefab/View/MainMenuView");
        public static readonly UIType OptionMenu = new UIType("Prefab/View/OptionMenuView");
        public static readonly UIType NextMenu = new UIType("Prefab/View/NextMenuView");
        public static readonly UIType HighScore = new UIType("Prefab/View/HighScoreView");
    }
}
