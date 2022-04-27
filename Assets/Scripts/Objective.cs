using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public enum ObjectiveType {PickCorrect, Calculate, BreakAmpulle}
    public ObjectiveType objectiveType;
    [SerializeField] private RestartLevel restartLevel;
    public bool isCompleted, currentObjective, objectiveFailed;
    public bool playerCanTry = true;
    //private float percentage, angle;
    public string title, description;
    public int playerTries = 3;


    // Start is called before the first frame update
    void Start()
    {
        isCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentObjective)
            {
                PlayerObjective();
                PlayerTries();
            }
    }


    public void PlayerObjective()
    {
        switch (objectiveType)
        {
            case ObjectiveType.PickCorrect:
                if(Desk.singleton.correctMedicine && playerCanTry)
                {
                    isCompleted = true;
                }
                if(Desk.singleton.wrongMedicine && playerCanTry)
                {
                    isCompleted = false;
                    playerTries -= 1;
                }
                break;

            case ObjectiveType.Calculate:
                if(CalculatorScript.singleton.result == CalculatorScript.singleton.correctAnswer)
                {
                    isCompleted = true;
                }
                break;
            case ObjectiveType.BreakAmpulle:
               /* if(ampulleBroken)
                {
                    isCompleted = true;
                } */
                break;
        }
        
    }
    public void PlayerTries()
    {
        if(playerTries <= 0)
        {
            playerCanTry = false;
            restartLevel.Restart();
        }
    }
}
