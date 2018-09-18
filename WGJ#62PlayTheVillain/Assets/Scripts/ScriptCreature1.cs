using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCreature1 : MonoBehaviour {

    [SerializeField]
    private float speed;

    [SerializeField]
    private int attackPoint;

    [SerializeField]
    private int attackSpeed;

    private float step;
    
    private ArrayList path;

    private Vector3 currentPosition;
    private int iteration;

    private float timer;

    private bool isInCombat;
    private GameObject currentEnnemy;

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

        isInCombat = false;

	}
	
	// Update is called once per frame
	void Update () {

        //ennemy detection
        Vector2 rayStart = new Vector2(gameObject.transform.position.x + 0.5f, gameObject.transform.position.y - 0.55f);
        RaycastHit2D ray = Physics2D.Raycast(rayStart, -Vector2.up);
        if (ray.collider != null)
        {
            //Debug.DrawRay(rayStart, -Vector2.up);
            isInCombat = true;
            currentEnnemy = ray.collider.gameObject;
        }

        //translation  
        if (isInCombat == false)
        {
            if (iteration < path.Count && gameObject.transform.position == currentPosition)
            {

                currentPosition = (Vector3)path[iteration];

                iteration = iteration + 1;

            }

            step = speed * Time.deltaTime;

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, currentPosition, step);
        }
        else
        {
            timer = timer + Time.deltaTime;

            if (timer >= attackSpeed && currentEnnemy.GetComponent<ScriptEnnemy1>().GetHealth() > 0)
            {

                currentEnnemy.GetComponent<ScriptEnnemy1>().SetHealth(currentEnnemy.GetComponent<ScriptEnnemy1>().GetHealth() - attackPoint);

                if ((currentEnnemy != null && currentEnnemy.GetComponent<ScriptEnnemy1>().GetHealth() <= 0) || currentEnnemy == null)
                {
                    isInCombat = false;
                }

                timer = 0;

            }

        }

    }
}
