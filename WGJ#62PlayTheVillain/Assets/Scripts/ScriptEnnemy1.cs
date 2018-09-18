using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnnemy1 : MonoBehaviour {

    [SerializeField]
    private int health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
	}

    //Health Getter
    public void SetHealth(int health)
    {
        this.health = health;
    }

    //Health Setter
    public int GetHealth()
    {
        return health;
    }

}
