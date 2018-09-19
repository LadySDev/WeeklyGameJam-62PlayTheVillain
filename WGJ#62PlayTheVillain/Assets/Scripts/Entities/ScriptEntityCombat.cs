using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEntityCombat : MonoBehaviour {

    [SerializeField]
    private bool isEnnemySide;

    [SerializeField]
    private int attackPoint;

    [SerializeField]
    private int attackSpeed;

    [SerializeField]
    private int magicPointLoot;

    [SerializeField]
    private float detectionDistance;

    private float timer;
    private bool isInCombat;
    private GameObject currentEnnemy;

    private ScriptMagicPoint scriptMP;
    private ScriptEntityDetectionZone scriptDetectZone;

    // Use this for initialization
    void Start () {        

        timer = 0;

        isInCombat = false;

        scriptMP = GameObject.Find("TxtMagicPointNumber").GetComponent<ScriptMagicPoint>();

        GameObject detectZone = new GameObject(gameObject.name + "DetectZone");
        detectZone.transform.parent = gameObject.transform;
        detectZone.transform.localPosition = new Vector3(0, 0, 0);

        Rigidbody2D rb2d = detectZone.AddComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;

        BoxCollider2D bc2d = detectZone.AddComponent<BoxCollider2D>();
        bc2d.isTrigger = true;
        bc2d.size = new Vector2(detectionDistance, detectionDistance);

        scriptDetectZone = detectZone.AddComponent<ScriptEntityDetectionZone>();
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

        //detect something
        if (scriptDetectZone.GetIsDetectedSomething() == true)
        {            
            isInCombat = true;
            currentEnnemy = scriptDetectZone.GetDetectedObject();
            scriptDetectZone.SetIsDetectedSomething(false);
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

    public bool GetIsEnnemySide()
    {
        return isEnnemySide;
    }

}
