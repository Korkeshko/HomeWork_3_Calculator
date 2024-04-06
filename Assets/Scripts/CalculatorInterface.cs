using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data;

public class CalculatorInterface : MonoBehaviour
{
    public TextMeshProUGUI DisplayText;
    public string CurrentInput = "";
    public double result;

    public void Button_Click()
    {
        DisplayText.text += CurrentInput;
    }

    public void Button_Click_Equals()
    {
        DataTable dt = new DataTable();
        result = System.Convert.ToDouble(dt.Compute(DisplayText.text, ""));
        DisplayText.text = result.ToString("", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
    }

    public void Button_Click_C()
    {
        DisplayText.text = "";
    }
}
