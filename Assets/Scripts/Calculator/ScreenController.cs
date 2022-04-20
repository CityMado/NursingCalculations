using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenController : MonoBehaviour
{
    public TextMeshProUGUI inputUp;
    public TextMeshProUGUI result;
    public string savedFirstInput;
    public string savedOperator;
    
    void Update()
    {
        SetText();
        SaveText();
    }

    public void SetText()
    {
        if(!CalculatorScript.singleton.firstOperatorUsed)
        {
            inputUp.text = CalculatorScript.singleton.currentInput;
            result.text = null;
        }
    }
    public void SaveText()
    {
        if(CalculatorScript.singleton.firstOperatorUsed && !CalculatorScript.singleton.secondOperatorUsed)
        {
            savedFirstInput = CalculatorScript.singleton.input.ToString();
            inputUp.text = savedFirstInput;
            savedOperator = CalculatorScript.singleton.selectedOperator;
            inputUp.text = savedFirstInput + savedOperator + CalculatorScript.singleton.currentInput;
        }
        if(CalculatorScript.singleton.secondOperatorUsed && CalculatorScript.singleton.firstOperatorUsed)
        {
            result.text = CalculatorScript.singleton.result.ToString();
        }
    }
}
