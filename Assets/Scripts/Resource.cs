using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    // Define variables
    
    [HideInInspector]
    public string resourceName;
    [HideInInspector]
    public double currentAmount;
    [HideInInspector]
    public double storageAmount;
    [HideInInspector]
    public double earningAmount;
    [HideInInspector]
    public double consumptionAmount;
    [HideInInspector]
    public Resource consumedResource;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Collect()
    {
        if (currentAmount < storageAmount)
        {

            if (consumedResource != null)
            {
                double consumption = consumptionAmount;
                if (consumedResource.currentAmount >= consumption)
                {
                    consumedResource.currentAmount -= consumption;
                    currentAmount += earningAmount;
                    CheckDiscoveryEvents();
                }
                else
                {
                    ;
                }
            }
            else
            {
                currentAmount += earningAmount;
                CheckDiscoveryEvents();
            }
        }
    }

    public virtual void CheckDiscoveryEvents()
    {

    }

}
