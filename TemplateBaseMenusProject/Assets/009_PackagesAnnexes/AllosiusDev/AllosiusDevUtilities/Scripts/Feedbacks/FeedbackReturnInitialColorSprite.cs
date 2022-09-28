//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AllosiusDevUtilities
{
    [Serializable]
    public class FeedbackReturnInitialColorSprite : BaseFeedback
    {
        public override IEnumerator Execute(GameObject _owner)
        {
            if (IsActive)
            {
                if (spriteRenderer != null && spriteRendererBaseColor != null)
                {
                    Debug.Log("Return Initial Color");
                    spriteRenderer.color = spriteRendererBaseColor;
                }
                else
                {
                    Debug.LogWarning("SpriteRenderer or SpriteRendererBaseColor is null");
                }
            }
            return base.Execute(_owner);
        }
    }
}
