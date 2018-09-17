using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnMenu : MonoBehaviour {

    private Button btnMenu;

    private GameObject menu;

    // Use this for initialization
    void Start () {

        btnMenu = gameObject.GetComponent<Button>();
        btnMenu.onClick.AddListener(ShowMenu);

        menu = GameObject.Find("Menu");

    }

    private void ShowMenu()
    {

        Time.timeScale = 0;

        menu.SetActive(true);

        btnMenu.interactable = false;

        foreach (Transform child in GameObject.Find("PanelCreatures").transform)
        {
            child.gameObject.GetComponent<Button>().interactable = false;
        }
                
    }

}
