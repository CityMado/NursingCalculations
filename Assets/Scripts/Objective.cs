using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public enum ObjectiveType {PickCorrect, Calculate, BreakAmpulle, UseTowelOnAmpule, UseTowelOnDesk, DestroyAmpulle, WashHands, ChooseSyringe, CalculateSolution, WashHands2nd, AttachPerfusor, AttachNeedle, OpenBottle, AttachFilterNeedle, UseTowelOnGlucose, ChangeNeedle, TakeMedicine, TransferMedicine, ChooseBigSyringe, TakeSolution, RemoveNeedleBeforePerfursor}
    public ObjectiveType objectiveType;
    public AudioClip correctSound, voiceOver, wrongSound;
    public AudioSource audioSource;
    [SerializeField] private RestartLevel restartLevel;
    public bool isCompleted, currentObjective, objectiveFailed;
    public bool playerCanTry = true;
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
                if(Desk.singleton.correctMedicine && playerCanTry && currentObjective)
                {
                    isCompleted = true;
                    Desk.singleton.Ampulle.SetActive(true);
                    Desk.singleton.towel.SetActive(true);
                    audioSource.PlayOneShot(correctSound);
                }
                if(Desk.singleton.wrongMedicine && playerCanTry && currentObjective)
                {
                    isCompleted = false;
                    playerTries -= 1;
                }
                break;
            case ObjectiveType.ChooseSyringe:
                if(Desk.singleton.correctSyringe)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;

            case ObjectiveType.Calculate:
                if(CalculatorScript.singleton.result == CalculatorScript.singleton.correctAnswer && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                if(CalculatorScript.singleton.result > CalculatorScript.singleton.correctAnswer && currentObjective)
                {
                    isCompleted = false;
                    if(!audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(voiceOver);
                    }
                }
               /* 
               if(CalculatorScript.singleton.result < CalculatorScript.singleton.correctAnswer)
                {
                    isCompleted = false;
                    if(!audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(wrongSound);
                    }
                } */               
                break;
            case ObjectiveType.CalculateSolution:
                if(CalculatorScript.singleton.result == CalculatorScript.singleton.correctSolution && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                if(CalculatorScript.singleton.result > CalculatorScript.singleton.correctSolution && currentObjective)
                {
                    isCompleted = false;
                    if(!audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(voiceOver);
                    }
                }
               /* 
               if(CalculatorScript.singleton.result < CalculatorScript.singleton.correctAnswer)
                {
                    isCompleted = false;
                    if(!audioSource.isPlaying)
                    {
                        audioSource.PlayOneShot(wrongSound);
                    }
                } */               
                break;
            case ObjectiveType.BreakAmpulle:
                if(MultipleObjectiveChecker.singleton.isBrokenAmpulle && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.UseTowelOnAmpule:
            {
                if(MultipleObjectiveChecker.singleton.hasCleanedAmpulle && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.UseTowelOnDesk:
            {
                if(MultipleObjectiveChecker.singleton.hasCleanedTable && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.UseTowelOnGlucose:
            {
                if(MultipleObjectiveChecker.singleton.hasCleanedGlucose && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.DestroyAmpulle:
            {
                if(YellowBox.singleton.ampulleDestroyed && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.WashHands:
                
                if(MultipleObjectiveChecker.singleton.rightHandWashed && MultipleObjectiveChecker.singleton.leftHandWashed && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.WashHands2nd:
                if(MultipleObjectiveChecker.singleton.rightHandSecondWash && MultipleObjectiveChecker.singleton.leftHandSecondWash && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.AttachPerfusor:
                if(MultipleObjectiveChecker.singleton.perfursorAttached && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.AttachNeedle:
                if(MultipleObjectiveChecker.singleton.needleAttached && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.OpenBottle:
                if(MultipleObjectiveChecker.singleton.isBrokenGlucose && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.AttachFilterNeedle:
                if(MultipleObjectiveChecker.singleton.needleFilterAttached && currentObjective)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.ChangeNeedle:
            if(YellowBox.singleton.needleFilterDestroyed && MultipleObjectiveChecker.singleton.needleAttached && currentObjective)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
            break;
            case ObjectiveType.TakeMedicine:
            if(MultipleObjectiveChecker.singleton.drugTakenAmpulle && currentObjective)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
            break;
            case ObjectiveType.TransferMedicine:
            if(MultipleObjectiveChecker.singleton.drugTransfered && currentObjective)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
            break;
            case ObjectiveType.ChooseBigSyringe:
            if(Desk.singleton.corretBigSyringe && currentObjective)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
            break;
            case ObjectiveType.TakeSolution:
            if(MultipleObjectiveChecker.singleton.solutionTaken && currentObjective)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
            break;
            case ObjectiveType.RemoveNeedleBeforePerfursor:
            if(MultipleObjectiveChecker.singleton.needleRemoved)
            {
                isCompleted = true;
                audioSource.PlayOneShot(correctSound);
            }
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
