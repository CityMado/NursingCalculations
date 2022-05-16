using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWashing : MonoBehaviour
{
    public enum HandSide {Right, Left, Right2, Left2}
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
                     handSide = HandSide.Right2;
                    }
                    break;
                case HandSide.Left:
                    if(objective.currentObjective)
                    {
                     MultipleObjectiveChecker.singleton.leftHandWashed = true;
                     handSide = HandSide.Left2;
                    }
                    break;
                case HandSide.Right2:
                if(objective.currentObjective)
                {
                    MultipleObjectiveChecker.singleton.rightHandSecondWash = true;
                }
                break;
                case HandSide.Left2:
                if(objective.currentObjective)
                {
                    MultipleObjectiveChecker.singleton.leftHandSecondWash = true;
                }
                break;
            }
            
        }  
    }
}
