using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptMagicPoint : MonoBehaviour {
        
    [SerializeField]
    private int mp;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = mp + " MP";
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = mp + " MP";        
    }

    public void AddMagicPoint(int magicPoint)
    {
        mp = mp + magicPoint;
    }

    public int GetMagicPoint()
    {
        return mp;
    }

}
