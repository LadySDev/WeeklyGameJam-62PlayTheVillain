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

    [SerializeField]
    private GameObject ennemy2;

    private GameObject paths;
    private GameObject grounds;
    private GameObject ennemies;

    private ArrayList levelList;
    private int levelNumber;   

    private Vector2 startPosition;
    private Vector2 goalPosition;

    private bool win;
    private bool lose;

    private void Awake()
    {
        LevelList list = new LevelList();
        
        levelList = list.GetLevelList();

        levelNumber = 1;        

        BuildLevel();

    }

    // Use this for initialization
    void Start () {
           
    }
	
	// Update is called once per frame
	void Update () {

        if (win == false && IsPlayerWin() == true)
        {
            Win();
            
            win = true;
        }

        if (lose == false && IsPlayerLose() == true)
        {
            Lose();           

            lose = true;
        }

    }

    public Vector2 GetStartPosition()
    {
        return startPosition;
    }

    public Vector2 GetGoalPosition()
    {
        return goalPosition;
    }

    public int GetLevelNumber()
    {
        return levelNumber;
    }

    public void SetLevelNumber(int number)
    {
        levelNumber = number;
    }

    public int GetMaxLevelNumber()
    {
        return levelList.Count;
    }

    private bool IsPlayerWin()
    {
        bool IsOneCreatureReachGoal = false;

        foreach (Transform child in GameObject.Find("PlayerArmy").transform)
        {
            if (child.position == new Vector3(goalPosition.x, goalPosition.y, 0))
            {
                IsOneCreatureReachGoal = true;
            }           
        }

        return IsOneCreatureReachGoal;

    }

    private void Win()
    {
        GameObject.Find("BtnMenu").GetComponent<ScriptBtnMenu>().ShowWinMenu();  
                
    }

    private bool IsPlayerLose()
    {
        bool isPlayerLose = false;

        if (GameObject.Find("PlayerArmy").transform.childCount == 0 && GameObject.Find("TxtMagicPointNumber").GetComponent<ScriptMagicPoint>().GetMagicPoint() == 0)
        {
            isPlayerLose = true;
        }

        return isPlayerLose;
    }

    private void Lose()
    {
        GameObject.Find("BtnMenu").GetComponent<ScriptBtnMenu>().ShowLoseMenu();
    }

    private void ClearLevel()
    {
        //Ground
        if (GameObject.Find("Grounds"))
        {
            Destroy(GameObject.Find("Grounds"));
        }

        //Path
        if (GameObject.Find("Paths"))
        {
            Destroy(GameObject.Find("Paths"));
        }

        //Ennemies
        if (GameObject.Find("Ennemies"))
        {
            Destroy(GameObject.Find("Ennemies"));
        }

        //Start Position
        startPosition = new Vector2(0, 0);

        //Goal Position
        goalPosition = new Vector2(0, 0);

        //Player Army
        if (GameObject.Find("PlayerArmy").transform.childCount > 0)
        {
            foreach (Transform child in GameObject.Find("PlayerArmy").transform)
            {
                Destroy(child.gameObject);
            }
        }

    }

    public void BuildLevel()
    {
        ClearLevel();

        Level level = (Level)levelList[levelNumber - 1];

        int rows = level.GetLevelGround().GetLength(0);
        int cols = level.GetLevelGround().GetLength(1);

        //browse the level1 array Ground
        grounds = new GameObject("Grounds");
        grounds.transform.parent = gameObject.transform;

        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                //get the value at the position x and y
                int value = level.GetLevelGround()[y, x];

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

        for (int i = 0; i < level.GetLevelPath().Length; i++)
        {
            Vector2 v2 = level.GetLevelPath()[i];
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
                int value = level.GetLevelEnnemies()[y, x];

                if (1 == value)
                {
                    GameObject i = Instantiate(ennemy1, ennemies.transform);
                    i.GetComponent<RectTransform>().position = new Vector3(x, -y, 0);
                }

                if (2 == value)
                {
                    GameObject i = Instantiate(ennemy2, ennemies.transform);
                    i.GetComponent<RectTransform>().position = new Vector3(x, -y, 0);
                }
            }
        }

        //Translation of the camera
        Camera.main.transform.position = new Vector3(level.GetCameraPosition().x,level.GetCameraPosition().y, Camera.main.transform.position.z);

        startPosition = level.GetStartPosition();
        
        goalPosition = level.GetGoalPosition();
       
        win = false;
        lose = false;
    }

}
