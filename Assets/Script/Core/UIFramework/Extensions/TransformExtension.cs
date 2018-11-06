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
using System.Collections;
using System.Collections.Generic;

namespace UIFramework
{
	public static class TransformExtension 
    {
        public static void DestroyChildren(this Transform trans)
        {
            foreach (Transform child in trans)
            {
                GameObject.Destroy(child.gameObject);
            }
        }

        public static Transform AddChildFromPrefab(this Transform trans, Transform prefab, string name = null)
        {
            Transform childTrans = GameObject.Instantiate(prefab) as Transform;
            childTrans.SetParent(trans, false);
            if (name != null)
	        {
                childTrans.gameObject.name = name;
	        }
            return childTrans;
        }
	}
}
