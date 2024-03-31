using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStartCheck : MonoBehaviour
{
    int AppleCardAccumlated;
    int BreadCardAccumlated;
    int ChocolateCardAccumlated;
    int ScoreAccumlated;
    [SerializeField] TMP_Text Apple;
    [SerializeField] TMP_Text Bread;
    [SerializeField] TMP_Text Chocolate;
    [SerializeField] TMP_Text Total;
    [SerializeField] TMP_Text Score;
    // Start is called before the first frame update
    void Awake()
    {
        AppleCardAccumlated = PlayerPrefs.GetInt("AppleAcc");
        BreadCardAccumlated = PlayerPrefs.GetInt("BreadAcc");
        ChocolateCardAccumlated = PlayerPrefs.GetInt("ChocolateAcc");
        ScoreAccumlated = PlayerPrefs.GetInt("ScoreAcc");

        AppleCardAccumlated += PlayerPrefs.GetInt("Apple");
        BreadCardAccumlated += PlayerPrefs.GetInt("Bread");
        ChocolateCardAccumlated += PlayerPrefs.GetInt("Chocolate");
        if(ScoreAccumlated > 0)
        {
            ScoreAccumlated += PlayerPrefs.GetInt("Score") + PlayerPrefs.GetInt("ScoreTime");
        }


        PlayerPrefs.SetInt("AppleAcc", AppleCardAccumlated);
        PlayerPrefs.SetInt("BreadAcc", BreadCardAccumlated);
        PlayerPrefs.SetInt("ChocolateAcc", ChocolateCardAccumlated);
        PlayerPrefs.SetInt("ScoreAcc", ScoreAccumlated);

        PlayerPrefs.SetInt("Apple", 0);
        PlayerPrefs.SetInt("Bread", 0);
        PlayerPrefs.SetInt("Chocolate", 0);
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("ScoreTime", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Apple != null)
        {
            Apple.text = AppleCardAccumlated.ToString();
        }
        if (Bread != null)
        {
            Bread.text = BreadCardAccumlated.ToString();
        }
        if (Chocolate != null) 
        { 
            Chocolate.text = ChocolateCardAccumlated.ToString(); 
        }
        if (Total != null)
        {
            Total.text = (AppleCardAccumlated + BreadCardAccumlated + ChocolateCardAccumlated).ToString();
        }
        if (Score != null)
        {
            Score.text = ScoreAccumlated.ToString();
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("AppleAcc", 0);
        PlayerPrefs.SetInt("BreadAcc", 0);
        PlayerPrefs.SetInt("ChocolateAcc", 0);
        PlayerPrefs.SetInt("ScoreAcc", 0);
    }
}
