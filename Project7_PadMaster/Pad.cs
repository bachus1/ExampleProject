using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project7_PadMaster
{


    public class Pad : MonoBehaviour
    {

        private PadMaster padMaster;
        [SerializeField]
        private bool isButton;


        public bool IsButton
        {

            get
            {
                return isButton;

            }
            set
            {
                isButton = value;
                padMaster.Reevaluate();
            }
        }

        private void Start()
        {
            padMaster = GetComponentInParent<PadMaster>();
        }

        private void OnValidate()
        {

            if (padMaster != null)
            {
                padMaster.Reevaluate();
            }


        }



    }



}


