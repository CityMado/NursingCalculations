using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    public TextMeshProUGUI inputUp;
    public TextMeshProUGUI result;
    public TextMeshProUGUI feedback;
    public string savedFirstInput;
    public string savedOperator;
    //Screen clear
    public float waitTime = 1f;
    
    
    void Update()
    {
        SetText();
        SaveText();
        //I don't think this needs to be in update but let's just keep it in here for tomorrow
        ResultCheck();
    }

    public void SetText()
    {
        if(!CalculatorScript.singleton.firstOperatorUsed && !CalculatorScript.singleton.checkResult)
        {
            inputUp.text = CalculatorScript.singleton.currentInput;
            //result.text = null;
        }
    }
    public void SaveText()
    {
        if(CalculatorScript.singleton.firstOperatorUsed && !CalculatorScript.singleton.secondOperatorUsed && !CalculatorScript.singleton.checkResult)
        {
            savedFirstInput = CalculatorScript.singleton.input.ToString();
            inputUp.text = savedFirstInput;
            savedOperator = CalculatorScript.singleton.selectedOperator;
            inputUp.text = savedFirstInput + savedOperator + CalculatorScript.singleton.currentInput;
        }
        if(CalculatorScript.singleton.secondOperatorUsed && CalculatorScript.singleton.firstOperatorUsed && !CalculatorScript.singleton.checkResult)
        {
            result.text = CalculatorScript.singleton.result.ToString();
        }
    }
    public void ResultCheck()
    {
     if(CalculatorScript.singleton.checkResult)
     {
        switch (CalculatorScript.singleton.subObjective)
         {
        case CalculatorScript.SubObjective.Gensymicin:
            if(CalculatorScript.singleton.result == CalculatorScript.singleton.correctAnswer)
            {
             feedback.text = "You got the correct answer";
             inputUp.text = null;
             result.text = CalculatorScript.singleton.result.ToString();
             StartCoroutine(AutomaticScreenClear(waitTime));
            CalculatorScript.singleton.subObjective = CalculatorScript.SubObjective.Solution;


            }
        if(CalculatorScript.singleton.result != CalculatorScript.singleton.correctAnswer)
        {
            if(CalculatorScript.singleton.result > CalculatorScript.singleton.correctAnswer)
            {
                feedback.text = "Answer is more than needed";
                inputUp.text = null;      
                result.text = CalculatorScript.singleton.result.ToString();          
                StartCoroutine(AutomaticScreenClear(waitTime));
            }
            if(CalculatorScript.singleton.result < CalculatorScript.singleton.correctAnswer)
            {
                feedback.text = "Answer is less than needed";
                inputUp.text = null;
                result.text = CalculatorScript.singleton.result.ToString();
                StartCoroutine(AutomaticScreenClear(waitTime));
            }            
         }
         break;
         case CalculatorScript.SubObjective.Solution:
            if(CalculatorScript.singleton.result == CalculatorScript.singleton.correctSolution)
            {
             feedback.text = "You got the correct answer";
             inputUp.text = null;
             result.text = CalculatorScript.singleton.result.ToString();
             StartCoroutine(AutomaticScreenClear(waitTime));

            }
        if(CalculatorScript.singleton.result != CalculatorScript.singleton.correctSolution)
        {
            if(CalculatorScript.singleton.result > CalculatorScript.singleton.correctSolution)
            {
                feedback.text = "Answer is more than needed";
                inputUp.text = null;      
                result.text = CalculatorScript.singleton.result.ToString();          
                StartCoroutine(AutomaticScreenClear(waitTime));
            }
            if(CalculatorScript.singleton.result < CalculatorScript.singleton.correctSolution)
            {
                feedback.text = "Answer is less than needed";
                inputUp.text = null;
                result.text = CalculatorScript.singleton.result.ToString();
                StartCoroutine(AutomaticScreenClear(waitTime));
            }            
         }
         break;        
     }
     } else feedback.text = null;
    }
    private IEnumerator AutomaticScreenClear(float seconds)
    {
        float counter = seconds;
        {
            while (counter > 0)
            {
                yield return new WaitForSeconds(1);
                counter--;
            }
             CalculatorScript.singleton.result = 0;
             CalculatorScript.singleton.checkResult = false;
        }
    }
}
