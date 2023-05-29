using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodResource : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        resourceName = "Wood";
        currentAmount = 0.0d;
        storageAmount = 10.0d;
        earningAmount = 0.1d;
        consumptionAmount = 0.1d;
        consumedResource = FindObjectOfType<FoodResource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
