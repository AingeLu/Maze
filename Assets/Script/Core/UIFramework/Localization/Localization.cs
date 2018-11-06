/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: 
** 应  用: Manage TextMap And Query Of Text

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
	public class Localization 
    {
        /* Language Types */
        public const string CHINESE = "Localization/Chinese.json";
        public const string ENGLISH = "Localization/English.json";

        private string _language;
        public string Language
        {
            get
            {
                return _language;
            }
            set
            {
                _language = value;
                TextAsset asset = Resources.Load<TextAsset>(_language);
                _languageNode = SimpleJSON.JSON.Parse(asset.text);
            }
        }

        private SimpleJSON.JSONNode _languageNode;

        private Localization()
        {
            Language = CHINESE;
        }

        public string GetText(string id)
        {
            return _languageNode[id];
        }
	}
}
