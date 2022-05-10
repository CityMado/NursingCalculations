using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWashing : MonoBehaviour
{
    public enum HandSide {Right, Left}
    public HandSide handSide;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Disinfectant")
        {
            switch (handSide)
            {
                case HandSide.Right:
                    CheckBothHands.singleton.rightHandWashed = true;
                    break;
                case HandSide.Left:
                    CheckBothHands.singleton.leftHandWashed = true;
                    break;
            }
            
        }  
    }
}
