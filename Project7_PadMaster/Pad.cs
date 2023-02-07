using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project7_PadMaster
{
    public class PadMaster : MonoBehaviour
    {

        public Pad pad1;        // Assign Pad through Inspector
        public Pad pad2;        // Assign Pad through Inspector

        public void Reevaluate()
        {
            if (pad1.IsActive && pad2.IsActive)
            {
                Debug.Log("Conditions fulfilled. Firing xxx!");
            }
            else
            {
                Debug.Log("Conditions not fulfilled. Doing nothing");
            }
        }
    }
}
