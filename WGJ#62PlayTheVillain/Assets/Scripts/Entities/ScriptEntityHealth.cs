using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEntityHealth : MonoBehaviour {

    [SerializeField]
    private int healthMax;

    [SerializeField]
    private int health;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    //Health Getter
    public int GetHealthMax()
    {
        return healthMax;
    }

    //Health Setter
    public void SetHealth(int health)
    {
        this.health = health;
    }

    //Health Getter
    public int GetHealth()
    {
        return health;
    }

}
