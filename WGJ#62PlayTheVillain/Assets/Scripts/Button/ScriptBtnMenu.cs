using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnMenu : MonoBehaviour {

    private Button btnMenu;
    
    // Use this for initialization
    void Start () {

        btnMenu = gameObject.GetComponent<Button>();
        btnMenu.onClick.AddListener(ShowMenu);
        
    }

    private void ShowMenu()
    {

        Time.timeScale = 0;

        GameObject[] sceneObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject go in sceneObjects)
        {
            if ("Menu" == go.name)
            {
                go.SetActive(true);
            }

            if ("TxtResult" == go.name)
            {
                go.SetActive(false);
            }

            if ("BtnNextLevel" == go.name)
            {
                go.SetActive(false);
            }

            if ("BtnContinue" == go.name)
            {
                go.GetComponent<Button>().interactable = true;
            }

        }
        
        btnMenu.interactable = false;

        foreach (Transform child in GameObject.Find("PanelCreatures").transform)
        {
            child.gameObject.GetComponent<BtnCreature>().SetCanBeInteractable(false);
        }
                
    }

    public void DisableMenu()
    {
        GameObject[] sceneObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject go in sceneObjects)
        {
            if ("Menu" == go.name)
            {
                go.SetActive(false);
            }
        }

        btnMenu.interactable = true;

        foreach (Transform child in GameObject.Find("PanelCreatures").transform)
        {
            child.gameObject.GetComponent<BtnCreature>().SetCanBeInteractable(true);
        }
        
        Time.timeScale = 1;
    }

    public void ShowWinMenu()
    {
        ShowMenu();

        ScriptLevelGenerator scrLevelGen = GameObject.Find("Level").GetComponent< ScriptLevelGenerator>();

        GameObject[] sceneObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject go in sceneObjects)
        {            
            if ("TxtResult" == go.name)
            {
                go.SetActive(true);
                go.GetComponent<Text>().text = "You Win !";
            }

            if ("BtnNextLevel" == go.name && scrLevelGen.GetLevelNumber() < scrLevelGen.GetMaxLevelNumber())
            {
                go.SetActive(true);
            }

            if ("BtnContinue" == go.name)
            {
                go.GetComponent<Button>().interactable = false;
            }

        }

    }

    public void ShowLoseMenu()
    {
        ShowMenu();

        GameObject[] sceneObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject go in sceneObjects)
        {           
            if ("TxtResult" == go.name)
            {
                go.SetActive(true);
                go.GetComponent<Text>().text = "You Lose !";
            }

            if ("BtnContinue" == go.name)
            {
                go.GetComponent<Button>().interactable = false;
            }

        }

    }
}
