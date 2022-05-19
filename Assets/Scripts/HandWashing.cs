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
                     MultipleObjectiveChecker.singleton.rightHandWashed = true;
                     handSide = HandSide.Right2;
                    break;
                case HandSide.Left:
                     MultipleObjectiveChecker.singleton.leftHandWashed = true;
                     handSide = HandSide.Left2;
                    break;
                case HandSide.Right2:
                if(objective.currentObjective && objective.objectiveType == Objective.ObjectiveType.WashHands2nd)
                {
                    MultipleObjectiveChecker.singleton.rightHandSecondWash = true;
                }
                break;
                case HandSide.Left2:
                if(objective.currentObjective && objective.objectiveType == Objective.ObjectiveType.WashHands2nd)
                {
                    MultipleObjectiveChecker.singleton.leftHandSecondWash = true;
                }
                break;
            }
            
        }  
    }
}
