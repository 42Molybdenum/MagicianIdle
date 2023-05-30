using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private Resource activeResource;
    public FoodResource foodResource;
    public ManaResource manaResource;
    public WoodResource woodResource;
    public StoneResource stoneResource;


    private void Awake()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        StartCoroutine(CollectResource());
        activeResource = null;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveResource(Resource resource)
    {
        activeResource = resource;
    }


    private IEnumerator CollectResource()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (activeResource != null)
            {
                activeResource.Collect();
            }
        }
    }
}
