using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodResource : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        resourceName = "Food";
        currentAmount = 0.0d;
        storageAmount = 10.0d;
        earningAmount = 0.1d;
        consumptionAmount = 0.2d;
        consumedResource = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
