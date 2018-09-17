using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnCreature : MonoBehaviour {

    private Text txtMP;
    private string strMP;
    private int mp;

    [SerializeField]
    private int cost;

    [SerializeField]
    private GameObject creature;

	// Use this for initialization
	void Start () {

        txtMP = GameObject.Find("TxtMagicPointNumber").GetComponent<Text>();
        SetCorrectMP();

        gameObject.GetComponent<Button>().onClick.AddListener(PlaceCreature);

    }
	
	// Update is called once per frame
	void Update () {
        SetCorrectMP();

        if (mp < cost)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }

    }

    private void SetCorrectMP()
    {
        strMP = txtMP.text;
        strMP = strMP.Substring(0, strMP.Length - 3);
        mp = int.Parse(strMP);
    }

    private void PlaceCreature()
    {
        //Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 position = new Vector3(-6.5f, 0.5f, 0);
        Instantiate(creature, position, Quaternion.identity, GameObject.Find("PlayerArmy").transform);

        txtMP.text = (mp - cost)+ " MP";
    }

}
