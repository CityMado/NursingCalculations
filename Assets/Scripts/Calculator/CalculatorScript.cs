using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CalculatorScript : MonoBehaviour
{
    public static CalculatorScript singleton;
    [SerializeField] private float input, input2;
    [SerializeField] private float result;
    [SerializeField] private string operation;
    public bool operatorPressed = false;
    public bool firstOperatorUsed = false;
    [SerializeField] private string currentInput;
    [SerializeField] private string selectedOperator;
    
    private void Awake()
    {
        singleton = this;
    }
    public void FirstInput(int currentNumber)
    {
        //getting the input of first number
        if(!string.IsNullOrEmpty(currentInput) && !operatorPressed)
        {
            if(currentInput.Length < 10)
            {
                currentInput += currentNumber;
            }
        }
        if(string.IsNullOrEmpty(currentInput) && !operatorPressed)
        {
            currentInput = currentNumber.ToString();
        }
    }

    public void SecondInput(int currentNumber)
    {
        Debug.Log("Täällä ollaan");
        if(!string.IsNullOrEmpty(currentInput) && !operatorPressed)
        {
            if(currentInput.Length < 10)
            {
                currentInput += currentNumber;
            }
        }
        if(string.IsNullOrEmpty(currentInput) && !operatorPressed)
        {
            currentInput = currentNumber.ToString();
        }
        if(operatorPressed)
        {
            input2 = Convert.ToInt32(currentInput);
        }  
    }

    public void Character(string currentCharacter)
    {
        if(!firstOperatorUsed && currentCharacter != "=")
        {
            input = Convert.ToInt32(currentInput);
            firstOperatorUsed = true;
            currentInput = null;
            selectedOperator = currentCharacter;
            operatorPressed = false;
        }
        if(currentCharacter == "=")
        {
            input2 = Convert.ToInt32(currentInput);
            currentInput = null; 
            switch (selectedOperator)
            {
                case "+":   
                    result = input + input2;
                    break;
                case "*":
                    result = input * input2;
                    break;
                case "/":
                    result = input / input2;
                    break;      
            }
            //saves for next time
            input = result;
            Debug.Log(result);
        }
    }
    //clears the whole calculator
    public void Clear()
    {
        input = 0;
        input2 = 0;
        result = 0;
        operation = null;
        operatorPressed = false;
        firstOperatorUsed = false;
        currentInput = null;
        selectedOperator = null;
    }
}
