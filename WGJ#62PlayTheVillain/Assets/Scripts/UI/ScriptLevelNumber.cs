using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptLevelNumber : MonoBehaviour {

    private ScriptLevelGenerator scrLevelGen;
    private int levelNumber;

	// Use this for initialization
	void Start () {
        scrLevelGen = GameObject.Find("Level").GetComponent<ScriptLevelGenerator>();
        levelNumber = scrLevelGen.GetLevelNumber();
        SetText();
    }
	
	// Update is called once per frame
	void Update () {
        levelNumber = scrLevelGen.GetLevelNumber();
        SetText();
    }

    private void SetText()
    {
        gameObject.GetComponent<Text>().text = "Level " + levelNumber;
    }
}
