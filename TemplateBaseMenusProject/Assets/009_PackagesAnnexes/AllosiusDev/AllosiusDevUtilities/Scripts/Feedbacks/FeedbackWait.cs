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
    public class FeedbackWait : BaseFeedback
    {
        public float waitTime;

        public override IEnumerator Execute(GameObject _owner)
        {
            if (IsActive)
            {
                Debug.Log("Wait");
                yield return new WaitForSeconds(waitTime);
            }
        }
    }
}
