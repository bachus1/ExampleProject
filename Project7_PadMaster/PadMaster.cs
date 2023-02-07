using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project7_PadMaster
{
    public class PadMaster : MonoBehaviour
    {

        public Pad pad1;        // Assign Pod through Inspector
        public Pad pad2;        // Assign Pod through Inspector


        private void Start()
        {

        }


        public void Reevaluate()
        {

            if (pad1.IsButton && pad2.IsButton)
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

