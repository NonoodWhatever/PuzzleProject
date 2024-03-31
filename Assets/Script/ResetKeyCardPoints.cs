using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetKeyCardPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefs.SetInt("Apple", 0);
        PlayerPrefs.SetInt("Bread", 0);
        PlayerPrefs.SetInt("Chocolate", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //e
    }
}
