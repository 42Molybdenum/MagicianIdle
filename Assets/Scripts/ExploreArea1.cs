using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreArea1 : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        resourceName = "ExploreArea1";
        currentAmount = 0.0d;
        storageAmount = 100.0d;
        earningAmount = 0.1d;
        consumptionAmount = 0.0d;
        consumedResource = FindObjectOfType<FoodResource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
