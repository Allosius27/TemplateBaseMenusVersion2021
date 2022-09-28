//
// Updated by Allosius(Yanis Q.) on 7/9/2022.
//

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllosiusDevUtilities
{
    [Serializable]
    public class FeedbackInstantiateObject : BaseFeedback
    {
        public GameObject objectToInstantiate;
        public Vector3 objectPositionOffset;

        public override IEnumerator Execute(GameObject _owner)
        {
            if(hasTarget)
            {
                GameObject _feedbackInstantiate = GameObject.Instantiate(objectToInstantiate, target + objectPositionOffset, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Target is null");
                GameObject _feedbackInstantiate = GameObject.Instantiate(objectToInstantiate, _owner.transform.position + objectPositionOffset, Quaternion.identity);
            }

            return base.Execute(_owner);
        }
    }
}
