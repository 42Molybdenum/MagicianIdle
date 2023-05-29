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

    // Define panels

    public GameObject introPanel;

    // Define texts
    
    private TMP_Text foodText;
    private TMP_Text manaText;
    private TMP_Text woodText;
    private TMP_Text stoneText;

    // Define buttons

    private Button collectFoodButton;
    private Button collectManaButton;
    private Button collectWoodButton;
    private Button collectStoneButton;
    private Button introButton;

    // Define sliders

    private Slider foodSlider;
    private Slider manaSlider;
    private Slider woodSlider;
    private Slider stoneSlider;




    private void Awake()
    {
        // Get Panels

        introPanel = GameObject.Find("IntroPanel");
        
        // Get texts

        foodText = GameObject.Find("FoodText").GetComponent<TMP_Text>();
        manaText = GameObject.Find("ManaText").GetComponent<TMP_Text>();
        woodText = GameObject.Find("WoodText").GetComponent<TMP_Text>();
        stoneText = GameObject.Find("StoneText").GetComponent<TMP_Text>();

        // Get buttons

        collectFoodButton = GameObject.Find("CollectFoodButton").GetComponent<Button>();
        collectManaButton = GameObject.Find("CollectManaButton").GetComponent<Button>();
        collectWoodButton = GameObject.Find("CollectWoodButton").GetComponent<Button>();
        collectStoneButton = GameObject.Find("CollectStoneButton").GetComponent<Button>();
        
        introButton = GameObject.Find("IntroButton").GetComponent<Button>();

        // Add button listeners

        collectFoodButton.onClick.AddListener(FoodButtonClicked);
        collectManaButton.onClick.AddListener(ManaButtonClicked);
        collectWoodButton.onClick.AddListener(WoodButtonClicked);
        collectStoneButton.onClick.AddListener(StoneButtonClicked);
        
        introButton.onClick.AddListener(CloseIntro);

        // Get sliders

        foodSlider = GameObject.Find("FoodSlider").GetComponent<Slider>();
        manaSlider = GameObject.Find("ManaSlider").GetComponent<Slider>();
        woodSlider = GameObject.Find("WoodSlider").GetComponent<Slider>();
        stoneSlider = GameObject.Find("StoneSlider").GetComponent<Slider>();

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

        foodSlider.maxValue = (float)foodResource.storageAmount;
        foodSlider.value = (float)foodResource.currentAmount;

        manaSlider.maxValue = (float)manaResource.storageAmount;
        manaSlider.value = (float)manaResource.currentAmount;

        woodSlider.maxValue = (float)woodResource.storageAmount;
        woodSlider.value = (float)woodResource.currentAmount;

        stoneSlider.maxValue = (float)stoneResource.storageAmount;
        stoneSlider.value = (float)stoneResource.currentAmount;
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

    public void CloseIntro()
    {
        introPanel.SetActive(false);
    }

}
