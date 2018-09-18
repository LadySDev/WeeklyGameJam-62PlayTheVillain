using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLevelGenerator : MonoBehaviour {

    [SerializeField]
    private GameObject path;

    [SerializeField]
    private GameObject ground;

    [SerializeField]
    private GameObject ennemy1;

    private GameObject paths;
    private GameObject grounds;
    private GameObject ennemies;

    private Level1 level1;
        
    // Use this for initialization
    void Start () {
        
        level1 = new Level1();

        int rows = level1.GetLevelGround().GetLength(0);
        int cols = level1.GetLevelGround().GetLength(1);

        //browse the level1 array Ground
        grounds = new GameObject("Grounds");
        grounds.transform.parent = gameObject.transform;

        for (int y=0;y<rows;y++)
        {
            for (int x=0;x<cols;x++)
            {
                //get the value at the position x and y
                int value = level1.GetLevelGround()[y, x];
               
                if (0 == value)
                {
                    GameObject instance = Instantiate(ground, new Vector3(x, -y, 0), Quaternion.identity, grounds.transform);
                    instance.GetComponent<SpriteRenderer>().sortingLayerName = "Ground";

                }
            }
        }

        //browse the level1 array Path
        paths = new GameObject("Paths");
        paths.transform.parent = gameObject.transform;

        for (int i=0;i<level1.GetLevelPath().Length;i++)
        {
            Vector2 v2 = level1.GetLevelPath()[i];
            Vector3 v3 = new Vector3(v2.x, v2.y, 0);

            GameObject instance = Instantiate(path, v3, Quaternion.identity, paths.transform);
            instance.GetComponent<SpriteRenderer>().sortingLayerName = "Path";

        }

        //browse the level1 array Ennemi
        ennemies = new GameObject("Ennemies");
        ennemies.transform.parent = gameObject.transform;

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                //get the value at the position x and y
                int value = level1.GetLevelEnnemies()[y, x];

                if (1 == value)
                {
                    Instantiate(ennemy1, new Vector3(x, -y, 0), Quaternion.identity, ennemies.transform);
                }
            }
        }

        //Translation of the camera
        Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + level1.GetCameraTranslation().x, Camera.main.transform.position.y + level1.GetCameraTranslation().y, Camera.main.transform.position.z);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector2 GetStartPosition()
    {
        return level1.GetStartPosition();
    }

    public Vector2 GetGoalPosition()
    {
        return level1.GetGoalPosition();
    }

}
