using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameEndWinnerLoser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //e
    }

    public void YOULOSE()
    {
        
    }
    public void YOUWIN()
    {
        SceneManager.LoadScene(0);
    }
}
