using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnContinue : MonoBehaviour {

    private GameObject menu;
    private Button btnContinue;

	// Use this for initialization
	void Start () {

        menu = GameObject.Find("Menu");

        btnContinue = gameObject.GetComponent<Button>();
        btnContinue.onClick.AddListener(DisableMenu);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void DisableMenu()
    {
        GameObject.Find("BtnMenu").GetComponent<Button>().interactable = true;

        foreach (Transform child in GameObject.Find("PanelCreatures").transform)
        {
            child.gameObject.GetComponent<Button>().interactable = true;
        }

        menu.SetActive(false);

        Time.timeScale = 1;
    }

}
