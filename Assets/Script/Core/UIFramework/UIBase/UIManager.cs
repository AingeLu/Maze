/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: 
** 应  用: Manage View's Create And Destory

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
    public class UIManager
    {
        public Dictionary<UIType, GameObject> _UIDict = new Dictionary<UIType,GameObject>();

        private Transform _canvas;

        private UIManager()
        {
            _canvas = GameObject.Find("Canvas").transform;
            foreach (Transform item in _canvas)
            {
                GameObject.Destroy(item.gameObject);
            }
        }

        public GameObject GetSingleUI(UIType uiType)
        {
            if (_UIDict.ContainsKey(uiType) == false || _UIDict[uiType] == null)
            {
                GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(uiType.Path)) as GameObject;
                go.transform.SetParent(_canvas, false);
                go.name = uiType.Name;
                _UIDict.AddOrReplace(uiType, go);
                return go;
            }
            return _UIDict[uiType];
        }

        public void DestroySingleUI(UIType uiType)
        {
            if (!_UIDict.ContainsKey(uiType))
            {
                return;
            }

            if (_UIDict[uiType] == null)
            {
                _UIDict.Remove(uiType);
                return;
            }

            GameObject.Destroy(_UIDict[uiType]);
            _UIDict.Remove(uiType);
        }

        public void Clear()
        {
            foreach (KeyValuePair<UIType, GameObject> data in _UIDict)
            {
                if (_UIDict[data.Key] != null)
                {
                    GameObject.Destroy(_UIDict[data.Key]);
                }
            }
            _UIDict.Clear();
        }
	}
}
