/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: Base Context For View
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
	public class BaseContext 
    {

        public UIType ViewType { get; private set; }

        public BaseContext(UIType viewType)
        {
            ViewType = viewType;
        }
	}
}
