using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CalculatorScript : MonoBehaviour
{
    public static CalculatorScript singleton;
    public enum SubObjective{Gensymicin, Solution}
    public SubObjective subObjective;

    public float input, input2;
    public float result;
    [SerializeField] private string operation;
    public bool operatorPressed = false;
    public bool firstOperatorUsed = false;
    public bool secondOperatorUsed = false;
    public bool checkResult = false;
    public string currentInput;
    public string selectedOperator;
    public float correctAnswer, correctSolution;
    
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
            secondOperatorUsed = true;
            input2 = Convert.ToInt32(currentInput);
            currentInput = null; 
            switch (selectedOperator)
            {
                case "+":   
                    result = input + input2;
                    checkResult = true;
                    //ResultCheck();
                    break;
                case "*":
                    result = input * input2;
                    checkResult = true;
                   // ResultCheck();
                    break;
                case "/":
                    result = input / input2;
                    checkResult = true;
                  //ResultCheck();
                    break;      
            }
            //saves for next time
            input = result;
            currentInput = result.ToString();
            input2 = 0;
            operation = null;
            operatorPressed = false;
            firstOperatorUsed = false;
 
            selectedOperator = null;
            secondOperatorUsed = false;
            Debug.Log(input);
            Debug.Log(result);
        }
    }

    //moved this to screencontroller. just because I dont want to worry about references :D
    public void ResultCheck()
    {
        if(result == correctAnswer)
        {
            Debug.Log("Good job you solved the problem ou jee");
        }
        if(result != correctAnswer)
        {
            if(result > correctAnswer)
            {
                Debug.Log("Your result is too much. Calculate again");
            }
            if(result < correctAnswer)
            {
                Debug.Log("Your answer is not enough. Try calculating again!");
            }           
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
        secondOperatorUsed = false;
    }
}
