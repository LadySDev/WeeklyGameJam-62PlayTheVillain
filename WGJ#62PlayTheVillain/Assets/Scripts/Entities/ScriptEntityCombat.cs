using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEntityCombat : MonoBehaviour {

    [SerializeField]
    private int attackPoint;

    [SerializeField]
    private int attackSpeed;

    [SerializeField]
    private int magicPointLoot;

    private float timer;
    private bool isInCombat;
    private GameObject currentEnnemy;

    private ScriptMagicPoint scriptMP;

    // Use this for initialization
    void Start () {
        timer = 0;

        isInCombat = false;

        scriptMP = GameObject.Find("TxtMagicPointNumber").GetComponent<ScriptMagicPoint>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        //death
        if (gameObject.GetComponent<ScriptEntityHealth>().GetHealth() <= 0)
        {
            scriptMP.AddMagicPoint(magicPointLoot);

            Destroy(gameObject);
        }

        //ennemy detection
        Vector2 v2RayUp = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.55f);
        RaycastHit2D rayUp = Physics2D.Raycast(v2RayUp, Vector2.up);

        Vector2 v2RayDown = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.55f);
        RaycastHit2D rayDown = Physics2D.Raycast(v2RayDown, Vector2.down);

        Vector2 v2RayLeft = new Vector2(gameObject.transform.position.x - 0.55f, gameObject.transform.position.y);
        RaycastHit2D rayLeft = Physics2D.Raycast(v2RayLeft, Vector2.left);

        Vector2 v2RayRight = new Vector2(gameObject.transform.position.x + 0.55f, gameObject.transform.position.y);
        RaycastHit2D rayRight = Physics2D.Raycast(v2RayRight, Vector2.right);

        if (rayUp.collider != null)
        {
            isInCombat = true;
            currentEnnemy = rayUp.collider.gameObject;
        }
        else if (rayDown.collider != null)
        {
            isInCombat = true;
            currentEnnemy = rayDown.collider.gameObject;
        }
        else if (rayLeft.collider != null)
        {
            isInCombat = true;
            currentEnnemy = rayLeft.collider.gameObject;
        }
        else if (rayRight.collider != null)
        {
            isInCombat = true;
            currentEnnemy = rayRight.collider.gameObject;
        }

        //combat begin
        if (isInCombat == true)
        {
            timer = timer + Time.deltaTime;

            if (timer >= attackSpeed && currentEnnemy.GetComponent<ScriptEntityHealth>().GetHealth() > 0)
            {

                currentEnnemy.GetComponent<ScriptEntityHealth>().SetHealth(currentEnnemy.GetComponent<ScriptEntityHealth>().GetHealth() - attackPoint);

                if ((currentEnnemy != null && currentEnnemy.GetComponent<ScriptEntityHealth>().GetHealth() <= 0) || currentEnnemy == null)
                {
                    isInCombat = false;
                }

                timer = 0;

            }

        }

    }

    //IsInCombat Getter
    public bool GetIsInCombat()
    {
        return isInCombat;
    }

}
