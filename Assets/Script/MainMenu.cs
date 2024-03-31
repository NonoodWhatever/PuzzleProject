using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelPicker(int LVL)
    {
        SceneManager.LoadScene(LVL);
        //SceneManager.SetActiveScene(LVL);
    }
}
