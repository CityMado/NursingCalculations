using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public enum ObjectiveType {PickCorrect, Calculate, BreakAmpulle, UseTowel, DestroyAmpulle, WashHands}
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
                if(Desk.singleton.correctMedicine && playerCanTry)
                {
                    isCompleted = true;
                    Desk.singleton.Ampulle.SetActive(true);
                    TowelScript.singleton.gameObject.SetActive(true);
                    audioSource.PlayOneShot(correctSound);
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
                    audioSource.PlayOneShot(correctSound);
                }
                if(CalculatorScript.singleton.result > CalculatorScript.singleton.correctAnswer)
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
                if(AmpulleScript.singleton.isBroken)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            case ObjectiveType.UseTowel:
            {
                if(TowelScript.singleton.hasCleaned)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.DestroyAmpulle:
            {
                if(YellowBox.singleton.ampulleDestroyed)
                {
                    isCompleted = true;
                    audioSource.PlayOneShot(correctSound);
                }
                break;
            }
            case ObjectiveType.WashHands:
                
                if(CheckBothHands.singleton.rightHandWashed && CheckBothHands.singleton.leftHandWashed)
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
