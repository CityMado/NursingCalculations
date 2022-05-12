using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWashing : MonoBehaviour
{
    public enum HandSide {Right, Left}
    public HandSide handSide;
    public Objective objective;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Disinfectant")
        {
            switch (handSide)
            {
                case HandSide.Right:
                    if(objective.currentObjective)
                    {
                     MultipleObjectiveChecker.singleton.rightHandWashed = true;
                    }
                    break;
                case HandSide.Left:
                    if(objective.currentObjective)
                    {
                     MultipleObjectiveChecker.singleton.leftHandWashed = true;
                    }
                    break;
            }
            
        }  
    }
}
