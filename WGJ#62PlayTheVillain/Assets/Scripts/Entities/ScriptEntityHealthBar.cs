using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEntityHealthBar : MonoBehaviour {

    private RectTransform rt;

    // Use this for initialization
    void Start()
    {

        //add canvas compponent
        Canvas c = gameObject.AddComponent<Canvas>();
        c.sortingLayerName = "UI";

        //new image ui
        GameObject healthBar = new GameObject(gameObject.name + "HealthBar");
        healthBar.transform.parent = gameObject.transform;
        healthBar.layer = 5;

        rt = healthBar.AddComponent<RectTransform>();
        rt.transform.localPosition = new Vector3(-0.5f, 1, 0);
        rt.pivot = new Vector2(0, 0.5f);
        rt.sizeDelta = new Vector2(1, 0.1f);

        healthBar.AddComponent<CanvasRenderer>();

        Image i = healthBar.AddComponent<Image>();
        i.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {

        int healthMax = gameObject.GetComponent<ScriptEntityHealth>().GetHealthMax();
        int health = gameObject.GetComponent<ScriptEntityHealth>().GetHealth();

        rt.sizeDelta = new Vector2((float)health / (float)healthMax, rt.sizeDelta.y);

    }
}
