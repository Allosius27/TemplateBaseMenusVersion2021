﻿//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using UnityEngine;

namespace AllosiusDevUtilities.Tween
{

    public class PositionTween : Vector3Tween
    {
#region Override Functions
        protected override void OnSetValue(Vector3 _val) {
            transform.localPosition = _val;
        }

        protected override void OnMoveValue(Vector3 _curr, Vector3 _target, float _nTime) {
            transform.localPosition = Vector3.Lerp(_curr, _target, _nTime);
        }
#endregion

    }

}
