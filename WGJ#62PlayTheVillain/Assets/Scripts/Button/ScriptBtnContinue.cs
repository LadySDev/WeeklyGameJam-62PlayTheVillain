using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnContinue : MonoBehaviour {
       

	// Use this for initialization
	void Start () {

        Button btnContinue = gameObject.GetComponent<Button>();
        btnContinue.onClick.AddListener(DisableMenu);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void DisableMenu()
    {
        GameObject.Find("BtnMenu").GetComponent<ScriptBtnMenu>().DisableMenu();
    }

}
