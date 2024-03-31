using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapArea : MonoBehaviour
{
    [SerializeField] GameObject CameraPos;
    //[SerializeField] int PageNumber;
    [SerializeField] GameObject[] CameraPosition;
    GameObject CamPosSelected;

    public void RotateLeft()
    {
        CameraPos.transform.Rotate(0, -90, 0);
    }
    public void RotateRight()
    {
        CameraPos.transform.Rotate(0, 90, 0);
    }

    public void MapMovement(int CamPos)
    { 
      CameraPos.transform.position = CameraPosition[CamPos].transform.position;
    }
}
