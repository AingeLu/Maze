/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: Base Animate View
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
	public abstract class AnimateView : BaseView 
    {
        [SerializeField]
        protected Animator _animator;

        public override void OnEnter(BaseContext context)
        {
            _animator.SetTrigger("OnEnter");
        }

        public override void OnExit(BaseContext context)
        {
            _animator.SetTrigger("OnExit");
        }

        public override void OnPause(BaseContext context)
        {
            _animator.SetTrigger("OnPause");
        }

        public override void OnResume(BaseContext context)
        {
            _animator.SetTrigger("OnResume");
        }

	}
}
