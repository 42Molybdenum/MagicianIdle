using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{

    public GameObject popupPanel;

    private Button popupButton;

    private void Awake()
    {
        popupButton = GameObject.Find("PopupButton").GetComponent<Button>();

        popupButton.onClick.AddListener(ClosePopup);

        OpenPopup();
    }

    public void OpenPopup()
    {
        popupPanel = GameObject.Find("PopupPanel");
    }




    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
