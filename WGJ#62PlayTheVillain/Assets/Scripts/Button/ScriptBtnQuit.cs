using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBtnQuit : MonoBehaviour {

    private Button btnQuit;

    // Use this for initialization
    void Start () {

        btnQuit = gameObject.GetComponent<Button>();
        btnQuit.onClick.AddListener(Quit);


    }

    private void Quit()
    {
        Application.Quit();
    }

}
