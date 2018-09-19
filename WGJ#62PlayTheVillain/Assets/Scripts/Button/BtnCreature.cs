using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnCreature : MonoBehaviour {

    private ScriptMagicPoint scriptMP;
    private int mp;

    [SerializeField]
    private int cost;

    [SerializeField]
    private GameObject creature;

    private Vector2 startPosition;

	// Use this for initialization
	void Start () {
        
        gameObject.GetComponent<Button>().onClick.AddListener(PlaceCreature);

        startPosition = GameObject.Find("Level").GetComponent<ScriptLevelGenerator>().GetStartPosition();

        scriptMP = GameObject.Find("TxtMagicPointNumber").GetComponent<ScriptMagicPoint>();
    }
	
	// Update is called once per frame
	void Update () {

        mp = scriptMP.GetMagicPoint();

        if (mp < cost)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }

    }

    private void PlaceCreature()
    {
        Vector3 position = new Vector3(startPosition.x, startPosition.y, 0);
        Instantiate(creature, position, Quaternion.identity, GameObject.Find("PlayerArmy").transform);
                
        scriptMP.AddMagicPoint(-cost);
    }

}
