using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GameObject.Find("TxtResult").SetActive(false);
        GameObject.Find("BtnNextLevel").SetActive(false);

        gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
