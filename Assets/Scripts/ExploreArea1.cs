using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreArea1 : Resource
{

    public event Action OnDiscoveryEvent1;


    [HideInInspector]
    public bool area1Discovery1 = false;

    // Start is called before the first frame update
    void Start()
    {
        resourceName = "ExploreArea1";
        currentAmount = 0.0d;
        storageAmount = 100.0d;
        earningAmount = 0.1d;
        consumptionAmount = 0.1d;
        consumedResource = FindObjectOfType<FoodResource>();

        OnDiscoveryEvent1 += HandleDiscoveryEvent1;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleDiscoveryEvent1()
    {
        Debug.Log("Event triggered");
        area1Discovery1 = true;
        Debug.Log(area1Discovery1);
    }

    public override void CheckDiscoveryEvents()
    {
        if (currentAmount >= 1.0d && !area1Discovery1)
        {
            OnDiscoveryEvent1.Invoke();
        }
    }
}
