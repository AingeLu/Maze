/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: 
** 应  用:

**************************** 修改记录 *******************************
** 修改人:
** 日  期:
** 描  述:
********************************************************************/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace UIFramework
{
    [RequireComponent(typeof(Text))]
    public class LocalizedText : MonoBehaviour
    {
        [SerializeField]
        private string _textID;
        public string TextID
        {
            get
            {
                return _textID;
            }
        }

        private Text _label;

        public void Start()
        {
            _label = GetComponent<Text>();
            SetupTextID(_textID);
        }

        public void SetupTextID(string textID)
        {
            _label.text = Singleton<Localization>.Instance.GetText(_textID);
        }

        public void SetupTextID(string textID, params object[] replaceParams)
        {

        }
    }
}
