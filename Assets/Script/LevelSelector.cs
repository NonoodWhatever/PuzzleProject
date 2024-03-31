using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] TMP_Dropdown LVLPick;
    [SerializeField] Button Goahead;
    
    void Update()
    {
       print(LVLPick.value);
        if(LVLPick.value == 0)
        {
            Goahead.interactable = false;
        }
        else
        {
            Goahead.interactable = true;
        }
    } 

    public void StartTheLevel()
    {
        SceneManager.LoadScene(LVLPick.value);
    }
}
