using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreArea1 : Resource
{

    public event Action OnDiscoveryEvent1;
    public event Action OnDiscoveryEvent2;


    [HideInInspector]
    public bool area1Discovery1 = false;
    public bool area1Discovery2 = false;

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
        OnDiscoveryEvent2 += HandleDiscoveryEvent2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleDiscoveryEvent1()
    {
        area1Discovery1 = true;
        uiManager.SetActive(uiManager.manaContainer);
    }

    private void HandleDiscoveryEvent2()
    {
        area1Discovery2 = true;
        uiManager.SetActive(uiManager.woodContainer);
    }

    public override void CheckDiscoveryEventsArea1()
    {
        if (currentAmount >= 1.0d && !area1Discovery1)
        {
            OnDiscoveryEvent1.Invoke();
        }
        if (currentAmount >= 2.5d && !area1Discovery2)
        {
            OnDiscoveryEvent2.Invoke();
        }
    }
}
