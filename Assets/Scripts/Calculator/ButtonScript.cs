using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public string currentCharacter;
    public int currentNumber;
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
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.One:
                    currentNumber = 1;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Two:
                    currentNumber = 2;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Three:
                    currentNumber = 3;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Four:
                    currentNumber = 4;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Five:
                    currentNumber = 5;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Six:
                    currentNumber = 6;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Seven:
                    currentNumber = 7;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Eight:
                    currentNumber = 8;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Nine:
                    currentNumber = 9;
                    if(!CalculatorScript.singleton.firstOperatorUsed)
                    {
                       CalculatorScript.singleton.FirstInput(currentNumber);
                    } else CalculatorScript.singleton.SecondInput(currentNumber);
                    break;
                case NumberButton.Plus:
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "+";
                    CalculatorScript.singleton.Character(currentCharacter);
                    break;
                case NumberButton.Divide:
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "/";
                    CalculatorScript.singleton.Character(currentCharacter);
                    break;
                case NumberButton.Multiply:
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "*";
                    CalculatorScript.singleton.Character(currentCharacter);
                    break;
                case NumberButton.Restart:
                    CalculatorScript.singleton.Clear();
                    break;
                case NumberButton.Equals:
                    CalculatorScript.singleton.operatorPressed = true;
                    currentCharacter = "=";
                    CalculatorScript.singleton.Character(currentCharacter);
                    break;
            }
            
        }
    }
}
