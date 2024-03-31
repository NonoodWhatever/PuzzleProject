using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TimeLimit : MonoBehaviour
{
    [SerializeField] TMP_Text TextThing;
    [SerializeField] int MinuteSelect;
    [SerializeField] int SecondSelect;
    [SerializeField] float TimeClock;
    [SerializeField] bool TimeLimitMode;
    [SerializeField] float ClockChecker;
    [SerializeField] int Minutes;
    [SerializeField] int Seconds;
    float ClockMax;
    int Score1;
    [SerializeField] int ScoreMax = 10000;
    // Start is called before the first frame update
    void Awake()
    {
        ClockMax = TimeClock;
        TimeClock += (float)SecondSelect;
        TimeClock += (float)(MinuteSelect * 60);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (TimeLimitMode == false)
            {
                TimeClock = ClockMax;
                TimeLimitMode = true; 
            }
            if(TimeLimitMode == true)
            {
                TimeLimitMode = false;
                TimeClock = 10000000000000000000000000f;
                PlayerPrefs.SetInt("ScoreTime", 0);
            }
        }

        if (TimeLimitMode == true)
        {
            TimeClock -= Time.deltaTime;
            ClockChecker = TimeClock;
            Minutes = Mathf.FloorToInt(TimeClock / 60);
            ClockChecker -= Minutes * 60;
            Seconds = Mathf.CeilToInt(ClockChecker);
            TextThing.text = Minutes + " : " + Seconds;
            Score1 = Mathf.RoundToInt(TimeClock / ClockMax) * ScoreMax;
            PlayerPrefs.SetInt("ScoreTime", Score1);
        }
        else
        {
            TextThing.text = " ";
        }

    if (TimeClock <= 0 && TimeLimitMode == false)
        {
            PlayerPrefs.SetInt("AppleAcc", 0);
            PlayerPrefs.SetInt("BreadAcc", 0);
            PlayerPrefs.SetInt("ChocolateAcc", 0);
            PlayerPrefs.SetInt("ScoreTime", 0);
            SceneManager.LoadScene(0);
            
        }
    }
}
