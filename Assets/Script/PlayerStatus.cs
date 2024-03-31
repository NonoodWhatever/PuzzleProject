using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerStatus : MonoBehaviour
{
    //[SerializeField] GameObject Self;
    // [SerializeField] GameObject check;
    public bool HaveKeyCardApple = false;
    public bool HaveKeyCardBread = false;
    public bool HaveKeyCardChocolate = false;
    [SerializeField] int CardApple;
    [SerializeField] int CardBread;
    [SerializeField] int CardChocolate;
    [SerializeField] TMP_Text AppleText;
    [SerializeField] TMP_Text BreadText;
    [SerializeField] TMP_Text ChocolateText;
    private void Start()
    {
        CardApple = PlayerPrefs.GetInt("Apple");
        CardBread = PlayerPrefs.GetInt("Bread");
        CardChocolate = PlayerPrefs.GetInt("Chocolate");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            CardApple++;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            CardBread++;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            CardChocolate++;
        }
        AppleText.text = CardApple.ToString();
        BreadText.text = CardBread.ToString();
        ChocolateText.text = CardChocolate.ToString();
        if (CardApple > 0)
        {
            HaveKeyCardApple = true;
        }
        else
        {
            HaveKeyCardApple = false;
        }

        if (CardBread > 0)
        {
            HaveKeyCardBread = true;
        }
        else
        {
            HaveKeyCardBread = false;
        }

        if (CardChocolate > 0)
        {
            HaveKeyCardChocolate = true;
        }
        else
        {
            HaveKeyCardChocolate = false;
        }
    }
    public void GetKeycard(int KeyCardType)
    {
        if (KeyCardType == 1)
        {
            CardApple++;
        }
        else if (KeyCardType == 2)
        {
            CardBread++;
        }
        else if (KeyCardType == 3)
        {
            CardChocolate++;
        }
        else
        {
            print("NULL CARD");
        }
    }
    public void RemoveKeycard(int KeyCardType)
    {
        if (KeyCardType == 1)
        {
            CardApple--;
        }
        else if (KeyCardType == 2)
        {
            CardBread--;
        }
        else if (KeyCardType == 3)
        {
            CardChocolate--;
        }
        else
        {
            print("NULL CARD");
        }
    }


    public void Deactivate(GameObject Self)
    {
        Self.SetActive(false);
    }
}
