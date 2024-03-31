using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class CodeColorHint : MonoBehaviour
{
    [SerializeField] CodeColor KeyCode;
    [SerializeField] SpriteRenderer[] ColorPlace;
    [SerializeField] int[] Num;
    //Color: 
    //  1 = (255,0,0,255)   2 = (0,0,245,255)   3 = (255,255,0,255) 
    //  4 = (0,255,67,255)  5 = (255,184,0,255)  6  = (234,0,255,255)
    public void StartColorCheck(int num1, int num2, int num3, int num4)
    {
        Num[0] = num1;
        Num[1] = num2;
        Num[2] = num3;
        Num[3] = num4;

        for (int i = 0; i <= 3; i++)
        {
            for (int c = 1; c <= 6; c++)
            {
                if (c == Num[i])
                {
                    PaintIt(i, c);
                }
            }
        }
    }
    void PaintIt(int Number, int Value)
    {
        if (Value == 1)
        {
            ColorPlace[Number].color = new Color32(255, 0, 0, 255);
        }
        if (Value == 2)
        {
            ColorPlace[Number].color = new Color32(0, 0, 245, 255);
        }
        if (Value == 3)
        {
            ColorPlace[Number].color = new Color32(255, 255, 0, 255);
        }
        if (Value == 4)
        {
            ColorPlace[Number].color = new Color32(0, 255, 67, 255);
        }
        if (Value == 5)
        {
            ColorPlace[Number].color = new Color32(255, 184, 0, 255);
        }
        if (Value == 6)
        {
            ColorPlace[Number].color = new Color32(234, 0, 255, 255);
        }
    }
}
