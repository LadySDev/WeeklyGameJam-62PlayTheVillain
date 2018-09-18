using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCreature1 : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float step;
    
    private ArrayList path;

    private Vector3 currentPosition;
    private int iteration;

    private float timer;

	// Use this for initialization
	void Start () {
        
        path = new ArrayList();

        foreach (Transform child in GameObject.Find("Paths").transform)
        {
            path.Add(child.position);
        }

        path.RemoveAt(0);

        iteration = 0;
        currentPosition = (Vector3)path[iteration];

        timer = 0;

	}
	
	// Update is called once per frame
	void Update () {
                
        if (iteration < path.Count && gameObject.transform.position == currentPosition) {

            currentPosition = (Vector3)path[iteration];
            
            iteration = iteration + 1;
                       
        }

        step = speed * Time.deltaTime;

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, currentPosition, step);
        
    }
}
