using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerObjectiveManager : MonoBehaviour
{
    //just stole old and ugly script I made for other course. Just testing if I could get it to function with our game
    public Objective[] objectives;
    public int currentIndex = 0;
    //public TextMeshProUGUI objDescription;
    [SerializeField] private bool  objectivesCompleted;


    private void Update()
    {
        AreObjectivesCompleted();
    }
    private bool AreObjectivesCompleted()
    {
        for (int i = 0; i < objectives.Length; ++i){
        if(objectives[i].isCompleted == false)
            { 
                if(objectives[currentIndex].isCompleted && objectives[currentIndex].currentObjective)
                {
                    objectives[currentIndex].currentObjective = false;
                    currentIndex++;
                    objectives[currentIndex].currentObjective = true;
                }
              return false;
            }
        }       
        objectivesCompleted = true;
        objectives[currentIndex].currentObjective = false;
        return true;
    }
}
