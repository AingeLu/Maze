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
using UnityEngine.EventSystems;

namespace UIFramework
{
    public class UIEventTriggerListener : EventTrigger
    {
        public delegate void VoidDelegate(GameObject go);
        public delegate void BoolDelegate(GameObject go, bool state);
        public delegate void FloatDelegate(GameObject go, float delta);
        public delegate void VectorDelegate(GameObject go, Vector2 delta);
        public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);
        public delegate void KeyCodeDelegate(GameObject go, KeyCode key);
        public delegate void PointerEventDelegate(GameObject go, PointerEventData eventData);

        public VoidDelegate onClick;
        public VoidDelegate onDoubleClick;
        public PointerEventDelegate onDown;
        public PointerEventDelegate onUpEvent;
        public VoidDelegate onEnter;
        public VoidDelegate onExit;
        public VoidDelegate onUp;
        public VoidDelegate onSelect;
        public VoidDelegate onUpdateSelect;
        public PointerEventDelegate onDrag;
        public VectorDelegate onScroll;
        public VoidDelegate onSubmit;

        static public UIEventTriggerListener Get(GameObject go)
        {
            UIEventTriggerListener listener = go.GetComponent<UIEventTriggerListener>();
            if (listener == null)
                listener = go.AddComponent<UIEventTriggerListener>();

            return listener;
        }
        public override void OnPointerClick(PointerEventData eventData)
        {
            if (onClick != null) onClick(gameObject);
        }
        public override void OnPointerDown(PointerEventData eventData)
        {
            if (onDown != null) onDown(gameObject, eventData);
        }
        public override void OnPointerEnter(PointerEventData eventData)
        {
            if (onEnter != null) onEnter(gameObject);
        }
        public override void OnPointerExit(PointerEventData eventData)
        {
            if (onExit != null) onExit(gameObject);
        }
        public override void OnPointerUp(PointerEventData eventData)
        {
            if (onUp != null) onUp(gameObject);
            if (onUpEvent != null) onUpEvent(gameObject, eventData);
        }
        public override void OnSelect(BaseEventData eventData)
        {
            if (onSelect != null) onSelect(gameObject);
        }
        public override void OnUpdateSelected(BaseEventData eventData)
        {
            if (onUpdateSelect != null) onUpdateSelect(gameObject);
        }


        public override void OnDrop(PointerEventData eventData)
        {
            //if (onDrag != null) onDrag(gameObject, eventData);
        }

        public override void OnDrag(PointerEventData eventData)
        {
            if (onDrag != null) onDrag(gameObject, eventData);
        }

        public override void OnScroll(PointerEventData eventData)
        {
            if (onScroll != null) onScroll(gameObject, eventData.scrollDelta);
        }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (onSubmit != null) onSubmit(gameObject);
        }
    }
}