using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEntityDetectionZone : MonoBehaviour {


    private bool isDetectedSomething;
    private GameObject detectedObject;

    private void Start()
    {
        isDetectedSomething = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (gameObject.transform.parent.gameObject != col.gameObject 
            && detectedObject == null 
            && col.gameObject.tag == "Entities"
            && gameObject.transform.parent.gameObject.GetComponent<ScriptEntityCombat>().GetIsEnnemySide() != col.gameObject.GetComponent<ScriptEntityCombat>().GetIsEnnemySide())
        {            
            isDetectedSomething = true;
            detectedObject = col.gameObject;
        }
        
    }

    public bool GetIsDetectedSomething()
    {
        return isDetectedSomething;
    }

    public void SetIsDetectedSomething(bool isDetected)
    {
        isDetectedSomething = isDetected;
    }

    public GameObject GetDetectedObject()
    {
        return detectedObject;
    }

    public void SetDetectedObject(GameObject obj)
    {
        detectedObject = obj;
    }
}
