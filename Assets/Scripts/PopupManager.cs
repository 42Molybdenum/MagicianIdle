using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    public GameManager gameManager;
    
    public GameObject popupPanel;

    private Button popupButton;

    private TMP_Text popupText;

    private void Awake()
    {
        popupButton = GameObject.Find("PopupButton").GetComponent<Button>();

        popupText = GameObject.Find("PopupText").GetComponent<TMP_Text>();

        popupButton.onClick.AddListener(ClosePopup);

        popupPanel = GameObject.Find("PopupPanel");

        OpenPopup();
    }

    public void OpenPopup()
    {
        popupPanel.SetActive(true);
        gameManager.activeResource = null;
    }


    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }

    public void Area1Discovery1Popup()
    {
        popupText.text = "Congratulations, you unlocked Mana!";
        OpenPopup();
    }

    public void Area1Discovery2Popup()
    {
        popupText.text = "Congratulations, you unlocked Wood!";
        OpenPopup();
    }

    public void Area1Discovery3Popup()
    {
        popupText.text = "Congratulations, you unlocked Stone!";
        OpenPopup();
    }
}
