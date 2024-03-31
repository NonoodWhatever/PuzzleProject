using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CodeColor : MonoBehaviour
{
    public int NumNeed1;
    public int NumNeed2;
    public int NumNeed3;
    public int NumNeed4;
    int Num1 = 0;
    int Num2 = 0;
    int Num3 = 0;
    int Num4 = 0;
    [SerializeField] bool RandomColor;
    [SerializeField] GameObject UnlockedObject;
    [SerializeField] GameObject RemoveObject;
    [SerializeField] GameObject BarNumberThing;
    //[SerializeField] GameObject Sound;
    [SerializeField] AudioSource SoundWrong;
    [SerializeField] AudioSource SoundRight;
    [SerializeField] CodeColorHint HintSystem;
    [SerializeField] GameObject[] CodeTexter;
    private void Start()
    {
        if(CodeTexter.Length != 4)
        {
            UnlockDoor();
            print("DOOR ERROR!!!");
        }
        if (RandomColor == true)
        {
            NumNeed1 = Random.Range(1, 6);
            NumNeed2 = Random.Range(1, 6);
            NumNeed3 = Random.Range(1, 6);
            NumNeed4 = Random.Range(1, 6);
        }
        else
        {
            NumNeed1 = 1; NumNeed2 = 1; NumNeed3 = 1; NumNeed4 = 1;
        }
        HintSystem.StartColorCheck(NumNeed1, NumNeed2, NumNeed3, NumNeed4);
    }

    private void Update()
    {
        if(Num4 != 0)
        {
            if(Num1 == NumNeed1 && Num2 == NumNeed2 && Num3 == NumNeed3 && Num4 == NumNeed4)
            {
                UnlockDoor();
                print("boom");  
            }
            else { NumReset(); }
        }
    }


    public void NumberPressed(int NumSelection)
    {
        print(NumSelection);
        if (Num1 == 0 )
        {
            Num1 = NumSelection;
            CodeTexter[0].SetActive(true);
        }
        else if(Num2 == 0)
        {
            Num2 = NumSelection;
            CodeTexter[1].SetActive(true);
        }
        else if (Num3 == 0)
        {
            Num3 = NumSelection;
            CodeTexter[2].SetActive(true);
        }
        else if (Num4 == 0 && Num1 != -1)
        {
            Num4 = NumSelection;
            CodeTexter[3].SetActive(true);
        }
    }
    void NumReset()
    {
        Num1 = 0;
        Num2 = 0;
        Num3 = 0;
        Num4 = 0;
        print("Reset");
        SoundWrong.Play();
        for (int i = 0;i <= CodeTexter.Length - 1; i++)
        {
            CodeTexter[i].SetActive(false);
        }
    }
    void UnlockDoor()
    {
        if (UnlockedObject != null) { UnlockedObject.SetActive(true); }
        if (RemoveObject != null) { RemoveObject.SetActive(false); }
        SoundRight.Play();
        Num1 = -1;
        Num4 = 0;
    }
}
