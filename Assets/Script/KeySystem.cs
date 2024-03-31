using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySystem : MonoBehaviour
{
    [SerializeField] bool OpenSesame;
    int RequirementToOpen;
    int NumberCheck;
    [SerializeField] bool KeyApple;
    [SerializeField] bool KeyBread;
    [SerializeField] bool KeyChocolate;
    [SerializeField] GameObject OpenedDoor;
    [SerializeField] GameObject ClosedDoor;
    [SerializeField] PlayerStatus CheckHaveKey;
    [SerializeField] bool TakeAwayCard;
        void Awake()
    {
        NumberCheck = 0;
        if(KeyApple == true)
        {
            RequirementToOpen++;
        }
        if(KeyBread == true)
        {
            RequirementToOpen++;
        }
        if (KeyChocolate == true)
        {
            RequirementToOpen++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckKey()
    {
        if (CheckHaveKey.HaveKeyCardApple == true && KeyApple == true)
        {
            NumberCheck++;
        }
        if(CheckHaveKey.HaveKeyCardBread == true && KeyBread == true)
        {
            NumberCheck++;
        }
        if (CheckHaveKey.HaveKeyCardChocolate == true && KeyChocolate == true)
        {
            NumberCheck++;
        }


        if (NumberCheck >= RequirementToOpen)
        {
            if (OpenedDoor != null)
            {
                OpenedDoor.SetActive(true);
            }
            ClosedDoor.SetActive(false);
            if (TakeAwayCard == true) {
                if (KeyApple == true)
                {
                    CheckHaveKey.RemoveKeycard(1);
                }
                if (KeyBread == true)
                {
                    CheckHaveKey.RemoveKeycard(2);
                }
                if (KeyChocolate == true)
                {
                    CheckHaveKey.RemoveKeycard(3);
                }
            }
        }
        else
        {
            NumberCheck = 0;
        }
    }
}
