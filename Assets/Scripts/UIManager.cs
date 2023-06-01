using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Define scripts

    public GameManager gameManager;


    public FoodResource foodResource;
    public ManaResource manaResource;
    public WoodResource woodResource;
    public StoneResource stoneResource;

    public ExploreArea1 exploreArea1;

    // Define panels

    public GameObject introPanel;

    // Define Game Objects

    public GameObject manaContainer;
    public GameObject woodContainer;
    
    // Define texts
    
    private TMP_Text foodText;
    private TMP_Text manaText;
    private TMP_Text woodText;
    private TMP_Text stoneText;

    private TMP_Text exploreArea1Text;

    // Define buttons

    private Button collectFoodButton;
    private Button collectManaButton;
    private Button collectWoodButton;
    private Button collectStoneButton;

    private Button exploreArea1Button;
    
    private Button introButton;

    // Define sliders

    private Slider foodSlider;
    private Slider manaSlider;
    private Slider woodSlider;
    private Slider stoneSlider;

    private Slider exploreArea1Slider;



    private void Awake()
    {
        // Get Panels

        introPanel = GameObject.Find("IntroPanel");

        // Get Game Objects

        manaContainer = GameObject.Find("ManaContainer");
        woodContainer = GameObject.Find("WoodContainer");

        // Get texts

        foodText = GameObject.Find("FoodText").GetComponent<TMP_Text>();
        manaText = GameObject.Find("ManaText").GetComponent<TMP_Text>();
        woodText = GameObject.Find("WoodText").GetComponent<TMP_Text>();
        stoneText = GameObject.Find("StoneText").GetComponent<TMP_Text>();

        exploreArea1Text = GameObject.Find("ExploreArea1Text").GetComponent<TMP_Text>();

        // Get buttons

        collectFoodButton = GameObject.Find("CollectFoodButton").GetComponent<Button>();
        collectManaButton = GameObject.Find("CollectManaButton").GetComponent<Button>();
        collectWoodButton = GameObject.Find("CollectWoodButton").GetComponent<Button>();
        collectStoneButton = GameObject.Find("CollectStoneButton").GetComponent<Button>();

        exploreArea1Button = GameObject.Find("ExploreArea1Button").GetComponent<Button>();

        introButton = GameObject.Find("IntroButton").GetComponent<Button>();

        // Add button listeners

        collectFoodButton.onClick.AddListener(FoodButtonClicked);
        collectManaButton.onClick.AddListener(ManaButtonClicked);
        collectWoodButton.onClick.AddListener(WoodButtonClicked);
        collectStoneButton.onClick.AddListener(StoneButtonClicked);

        exploreArea1Button.onClick.AddListener(ExploreArea1ButtonClicked);

        introButton.onClick.AddListener(CloseIntro);

        // Get sliders

        foodSlider = GameObject.Find("FoodSlider").GetComponent<Slider>();
        manaSlider = GameObject.Find("ManaSlider").GetComponent<Slider>();
        woodSlider = GameObject.Find("WoodSlider").GetComponent<Slider>();
        stoneSlider = GameObject.Find("StoneSlider").GetComponent<Slider>();

        exploreArea1Slider = GameObject.Find("ExploreArea1Slider").GetComponent<Slider>();

        // Set undiscovered buttons inactive

        // SetInactive(manaContainer);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodText.text = "Food: " + string.Format("{0:0.##}", foodResource.currentAmount);
        manaText.text = "Mana: " + string.Format("{0:0.##}", manaResource.currentAmount);
        woodText.text = "Wood: " + string.Format("{0:0.##}", woodResource.currentAmount);
        stoneText.text = "Stone: " + string.Format("{0:0.##}", stoneResource.currentAmount);

        exploreArea1Text.text = "Explored: " + string.Format("{0:0.##}", exploreArea1.currentAmount + "%");

        foodSlider.maxValue = (float)foodResource.storageAmount;
        foodSlider.value = (float)foodResource.currentAmount;

        manaSlider.maxValue = (float)manaResource.storageAmount;
        manaSlider.value = (float)manaResource.currentAmount;

        woodSlider.maxValue = (float)woodResource.storageAmount;
        woodSlider.value = (float)woodResource.currentAmount;

        stoneSlider.maxValue = (float)stoneResource.storageAmount;
        stoneSlider.value = (float)stoneResource.currentAmount;


        exploreArea1Slider.maxValue = (float)exploreArea1.storageAmount;
        exploreArea1Slider.value = (float)exploreArea1.currentAmount;
    }

    public void FoodButtonClicked()
    {
        gameManager.SetActiveResource(foodResource);
    }

    public void ManaButtonClicked()
    {
        gameManager.SetActiveResource(manaResource);
    }

    public void WoodButtonClicked()
    {
        gameManager.SetActiveResource(woodResource);
    }

    public void StoneButtonClicked()
    {
        gameManager.SetActiveResource(stoneResource);
    }

    public void ExploreArea1ButtonClicked()
    {
        gameManager.SetActiveResource(exploreArea1);
    }



    public void CloseIntro()
    {
        introPanel.SetActive(false);
    }

    public void SetInactive(GameObject obj)
    {
        CanvasGroup canvasGroup = obj.GetComponent<CanvasGroup>();
        
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }


    public void SetActive(GameObject obj)
    {
        CanvasGroup canvasGroup = obj.GetComponent<CanvasGroup>();

        canvasGroup.alpha = 1f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

}
