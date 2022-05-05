using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string currentCharacter;
    public int currentNumber;
    public bool canPressAgain = true;
    public float waitTime = 0.5f;
    public enum NumberButton {Zero,
    One, 
    Two, 
    Three, 
    Four, 
    Five, 
    Six,
    Seven,
    Eight,
    Nine,
    Equals,
    Plus,
    Divide, 
    Multiply,
    Restart
     };

    public NumberButton numbers;

    
    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = numbers.ToString();
    }
    //yeah it's ugly :D But here we are just sending the correct number to CalculatorScript
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            switch(numbers)
            {
                case NumberButton.Zero:
                    currentNumber = 0;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.One:
                    currentNumber = 1;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Two:
                    currentNumber = 2;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Three:
                    currentNumber = 3;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Four:
                    currentNumber = 4;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Five:
                    currentNumber = 5;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Six:
                    currentNumber = 6;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Seven:
                    currentNumber = 7;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Eight:
                    currentNumber = 8;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Nine:
                    currentNumber = 9;
                    if(!CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                       canPressAgain = false;
                       StartCoroutine(CanPressAgain(waitTime));
                    }
                    if(CalculatorScript.singleton.firstOperatorUsed && canPressAgain)
                    {
                        CalculatorScript.singleton.SecondInput(currentNumber);
                        canPressAgain = false;
                        StartCoroutine(CanPressAgain(waitTime));
                    }
                    break;
                case NumberButton.Plus:
                if(canPressAgain)
                {
                    canPressAgain = false;
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "+";
                    CalculatorScript.singleton.Character(currentCharacter);
                    StartCoroutine(CanPressAgain(waitTime));           
                }
                    break;
                case NumberButton.Divide:
                if(canPressAgain)
                {
                    canPressAgain = false;
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "/";
                    CalculatorScript.singleton.Character(currentCharacter);
                    StartCoroutine(CanPressAgain(waitTime));
                }
                    break;
                case NumberButton.Multiply:
                if(canPressAgain)
                {
                    canPressAgain = false;
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "*";
                    CalculatorScript.singleton.Character(currentCharacter);
                    StartCoroutine(CanPressAgain(waitTime));
                }
                    break;
                case NumberButton.Restart:
                if(canPressAgain)
                {
                    canPressAgain = false;
                    CalculatorScript.singleton.Clear();
                    StartCoroutine(CanPressAgain(waitTime));
                }
                    break;
                case NumberButton.Equals:
                if(canPressAgain)
                {
                    canPressAgain = false;
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "=";
                    CalculatorScript.singleton.Character(currentCharacter);
                    StartCoroutine(CanPressAgain(waitTime));
                }
                    break;
            }
            
        }
    }
        private IEnumerator CanPressAgain(float seconds)
    {
        float counter = seconds;
        {
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
            canPressAgain = true;
        }
    }
}
