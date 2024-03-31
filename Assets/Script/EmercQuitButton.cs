using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EmercQuitButton : MonoBehaviour
{
    [SerializeField] GameObject Peekaboo;
    [SerializeField] int SceneNum;
    [SerializeField] bool Return;
    private void Awake()
    {
        if (Peekaboo != null)
        {
            Peekaboo.SetActive(false);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { if(Peekaboo != null)
            {
                Peekaboo.SetActive(true);
            }
            if (Return == true)
            {
                //PlayerPrefs.SetInt("AppleAcc", 0);
                //PlayerPrefs.SetInt("BreadAcc", 0);
                //PlayerPrefs.SetInt("ChocolateAcc", 0);
                PlayerPrefs.SetInt("ScoreTime", 0);
                SceneManager.LoadScene(SceneNum);
            }
            else
            {
                //PlayerPrefs.SetInt("AppleAcc", 0);
                //PlayerPrefs.SetInt("BreadAcc", 0);
                //PlayerPrefs.SetInt("ChocolateAcc", 0);
                PlayerPrefs.SetInt("ScoreTime", 0);
                Application.Quit();
            }
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
