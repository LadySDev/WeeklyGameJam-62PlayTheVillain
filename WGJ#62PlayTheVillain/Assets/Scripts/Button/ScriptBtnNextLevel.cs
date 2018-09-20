using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnNextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button btnNextLevel = gameObject.GetComponent<Button>();
        btnNextLevel.onClick.AddListener(NextLevel);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void NextLevel()
    {
        ScriptLevelGenerator scrLevelGen = GameObject.Find("Level").GetComponent<ScriptLevelGenerator>();
        int levelNumber = scrLevelGen.GetLevelNumber();
        
        scrLevelGen.SetLevelNumber(levelNumber + 1);
        scrLevelGen.BuildLevel();

        GameObject.Find("BtnMenu").GetComponent<ScriptBtnMenu>().DisableMenu();
    }

}
