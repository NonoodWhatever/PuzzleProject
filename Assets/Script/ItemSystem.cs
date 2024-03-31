using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSystem : MonoBehaviour
{
    [SerializeField] bool OpenSesame;
    [SerializeField] bool OpenAfterInteract;
    bool RequirementToOpen;

    [SerializeField] GameObject OpenedDoor;
    [SerializeField] GameObject ClosedDoor;

    [SerializeField] GameObject ItemOfInterest;
    [SerializeField] GameObject ItemOfInterestInteracted;

    private void Awake()
    {
        RequirementToOpen = false;
    }

    public void BreakBarricade()
    {
        if(RequirementToOpen == true) 
        {
            OpenedDoor.SetActive(true);
            ClosedDoor.SetActive(false);
        }
        
    }
    public void GotItem()
    {
        if(OpenAfterInteract == true)
        {
            
            BreakBarricade();
        }
        ItemOfInterest.SetActive(false);
        if(ItemOfInterestInteracted != null)
        {
            ItemOfInterestInteracted.SetActive(true);
        }
        RequirementToOpen = true;
    }
}
