using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorConsole : MonoBehaviour
{
    public float Number1;
    public float Number2;
    public float Result;
    private string Operation;

    void Start()
    {
        Sum(); 
        Diff(); 
        Mult();
        Div();   
    }

    void Sum()
    {
        Result = Number1 + Number2;
        Console(Result, "Sum");
    }

    void Diff()
    {
        Result = Number1 - Number2;
        Console(Result, "Difference");
    }

    void Mult()
    {
        Result = Number1 * Number2;
        Console(Result, "Multiplication");
    }
    
    void Div()
    {
        Result = Number1 / Number2;
        Console(Result, "Divesion");
    }

    void Console(float Res, string Operation)
    {
        Debug.Log($"{Operation} = {Res}");    
    }
}