using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleObjectiveChecker : MonoBehaviour
{
    public static MultipleObjectiveChecker singleton;

    public bool hasCleanedAmpulle = false;
    public bool hasCleanedTable = false;
    public bool leftHandWashed = false;
    public bool rightHandWashed = false;


    private void Awake()
    {
        singleton = this;
    }

}
