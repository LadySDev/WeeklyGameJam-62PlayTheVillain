using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 {

    //Attributes
    private int[,] levelGround;

    private Vector2[] levelPath; 

    private int[,] levelEnnemies;

    private Vector2 startPosition;
    private Vector2 goalPosition;

    private Vector2 cameraTranslation;

    //Constructor
    public Level1()
    {

        levelGround = new int[,]{
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                };

        /*
         *                         {
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {x,x,x,x,x,x,x,x,x,x,x,x,x,x},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                    };
         */

        levelPath = new Vector2[]{
                                    new Vector2(0, -4),
                                    new Vector2(1, -4),
                                    new Vector2(2, -4),
                                    new Vector2(3, -4),
                                    new Vector2(4, -4),
                                    new Vector2(5, -4),
                                    new Vector2(6, -4),
                                    new Vector2(7, -4),
                                    new Vector2(8, -4),
                                    new Vector2(9, -4),
                                    new Vector2(10, -4),
                                    new Vector2(11, -4),
                                    new Vector2(12, -4),
                                    new Vector2(13, -4)
                                   };

        levelEnnemies = new int[,]{
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,1,0,0,0,2,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                    };

        startPosition = new Vector2(0, -4);
        goalPosition = new Vector2(13, -4);

        cameraTranslation = new Vector2(6.5f, -4.5f);

    }

    //LevelGround Getter
    public int[,] GetLevelGround()
    {
        return levelGround;
    }

    //LevelPath Getter
    public Vector2[] GetLevelPath()
    {
        return levelPath;
    }

    //LevelEnnemies Getter
    public int[,] GetLevelEnnemies()
    {
        return levelEnnemies;
    }

    //StartPosition Getter
    public Vector2 GetStartPosition()
    {
        return startPosition;
    }

    //GoalPosition Getter
    public Vector2 GetGoalPosition()
    {
        return goalPosition;
    }

    //CameraTranslation Getter
    public Vector2 GetCameraTranslation()
    {
        return cameraTranslation;
    }
}
