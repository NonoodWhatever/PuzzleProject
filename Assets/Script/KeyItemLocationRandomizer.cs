using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemLocationRandomizer : MonoBehaviour
{
    [SerializeField] GameObject[] Locations;
    int Randomizer;

    private void Awake()
    {
           Randomizer = Random.Range(0, Locations.Length);
        Locations[Randomizer].SetActive(true);
    }
}
