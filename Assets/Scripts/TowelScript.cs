using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelScript : MonoBehaviour
{

public enum SubObjective {Desk, Ampulle}
public SubObjective subObjective;
public Objective objective;

private void Start()
{
    if(subObjective == SubObjective.Ampulle)
    {
        gameObject.SetActive(false);
    }
}
 private void OnTriggerEnter(Collider other) 
    {
        switch (subObjective)
        {
            case SubObjective.Desk:
            {
                    if(other.tag == "Desk" && objective.currentObjective)
                    {
                        MultipleObjectiveChecker.singleton.hasCleanedTable = true;
                        //Destroy(gameObject, 5);
                    }
            }
                break;
            case SubObjective.Ampulle:
                {
                    if(other.tag == "ampulle"  && objective.currentObjective)
                    {
                        MultipleObjectiveChecker.singleton.hasCleanedAmpulle = true;
                       // Destroy(gameObject, 5);
                    }
                }
                break;
        }
            

    }
}
