/*******************************************************************
** 版  权:    (C) 卢松 2018 - All Rights Reserved
** 创建人: Simple.Lu
** 日  期: 2018-11-15 16:09
** 版  本: 1.0
** 描  述: 
** 应  用: Blend Color Using BaseVertexEffect

**************************** 修改记录 *******************************
** 修改人:
** 日  期:
** 描  述:
********************************************************************/

using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace UiEffect
{
    [AddComponentMenu ("UI/Effects/Blend Color")]
    [RequireComponent (typeof (Graphic))]
    public class BlendColor : BaseMeshEffect
    {
        public enum BLEND_MODE
        {
            Multiply,
            Additive,
            Subtractive,
            Override,
        }

        public BLEND_MODE blendMode = BLEND_MODE.Multiply;
        public Color color = Color.grey;

        Graphic graphic;

        public override void ModifyMesh(VertexHelper vh)
        {
            if (IsActive() == false || vh == null)
            {
                return;
            }

            //UIVertex tempVertex = vList[0];
            //for (int i = 0; i < vList.Count; i++)
            //{
            //    tempVertex = vList[i];
            //    byte orgAlpha = tempVertex.color.a;
            //    switch (blendMode)
            //    {
            //        case BLEND_MODE.Multiply:
            //            tempVertex.color *= color;
            //            break;
            //        case BLEND_MODE.Additive:
            //            tempVertex.color += color;
            //            break;
            //        case BLEND_MODE.Subtractive:
            //            tempVertex.color -= color;
            //            break;
            //        case BLEND_MODE.Override:
            //            tempVertex.color = color;
            //            break;
            //    }
            //    tempVertex.color.a = orgAlpha;
            //    vList[i] = tempVertex;
            //}
        }

        //public override void ModifyVertices (List<UIVertex> vList)
        //{
        //    if (IsActive () == false || vList == null || vList.Count == 0) {
        //        return;
        //    }

        //    UIVertex tempVertex = vList[0];
        //    for (int i = 0; i < vList.Count; i++) {
        //        tempVertex = vList[i];
        //        byte orgAlpha = tempVertex.color.a;
        //        switch (blendMode) {
        //            case BLEND_MODE.Multiply:
        //                tempVertex.color *= color;
        //                break;
        //            case BLEND_MODE.Additive:
        //                tempVertex.color += color;
        //                break;
        //            case BLEND_MODE.Subtractive:
        //                tempVertex.color -= color;
        //                break;
        //            case BLEND_MODE.Override:
        //                tempVertex.color = color;
        //                break;
        //        }
        //        tempVertex.color.a = orgAlpha;
        //        vList[i] = tempVertex;
        //    }
        //}

        /// <summary>
        /// Refresh Blend Color on playing.
        /// </summary>
        public void Refresh ()
        {
            if (graphic == null) {
                graphic = GetComponent<Graphic> ();
            }
            if (graphic != null) {
                graphic.SetVerticesDirty ();
            }
        }
    }
}
