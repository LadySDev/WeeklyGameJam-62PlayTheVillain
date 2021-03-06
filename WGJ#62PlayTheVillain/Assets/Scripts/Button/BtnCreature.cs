﻿using System.Collections;
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

    private ScriptLevelGenerator scrLevelGen;
    private Vector2 startPosition;

    private bool canBeInteractable;

    // Use this for initialization
	void Start () {
        
        gameObject.GetComponent<Button>().onClick.AddListener(PlaceCreature);

        scrLevelGen = GameObject.Find("Level").GetComponent<ScriptLevelGenerator>();
        startPosition = scrLevelGen.GetStartPosition();
        
        scriptMP = GameObject.Find("TxtMagicPointNumber").GetComponent<ScriptMagicPoint>();
        mp = scriptMP.GetMagicPoint();

        canBeInteractable = true;
    }
	
	// Update is called once per frame
	void Update () {

        startPosition = scrLevelGen.GetStartPosition();

        mp = scriptMP.GetMagicPoint();

        if (canBeInteractable == true)
        {
            if (mp < cost)
            {
                gameObject.GetComponent<Button>().interactable = false;
            }
            else
            {
                gameObject.GetComponent<Button>().interactable = true;
            }
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }

    private void PlaceCreature()
    {
        Vector3 position = new Vector3(startPosition.x, startPosition.y, 0);
        Instantiate(creature, position, Quaternion.identity, GameObject.Find("PlayerArmy").transform);
                
        scriptMP.AddMagicPoint(-cost);
    }

    public void SetCanBeInteractable(bool canBe)
    {
        canBeInteractable = canBe;
    }

}
