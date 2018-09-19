using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptBtnNewGame : MonoBehaviour {

    private Button btnNewGame;

	// Use this for initialization
	void Start () {

        btnNewGame = gameObject.GetComponent<Button>();
        btnNewGame.onClick.AddListener(NewGame);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void NewGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
