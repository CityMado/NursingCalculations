using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrugTransfer : MonoBehaviour
{
    public Objective objective;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Needle" && objective.currentObjective)
        {
            MultipleObjectiveChecker.singleton.drugTransfered = true;
        }
    }
}
