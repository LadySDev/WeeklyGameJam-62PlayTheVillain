using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelList {

    private ArrayList levelList;

    public LevelList()
    {
        levelList = new ArrayList();

        //Level 1

        //Level 1 Ground
        int[,] level1Ground = new int[,]{
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
        
        //Level 1 Path
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

        Vector2[] level1Path = new Vector2[]{
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

        //Level 1 Ennemies

        int[,] level1Ennemies = new int[,]{
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

        //Level 1 Start Position
        Vector2 level1StartPosition = new Vector2(0, -4);

        //Level 1 Goal Position
        Vector2 level1GoalPosition = new Vector2(13, -4);

        //Level 1 Camera Position
        Vector2 level1CameraPosition = new Vector2(6.5f, -4.5f);
        
        NewLevel(level1Ground, level1Path, level1Ennemies, level1StartPosition, level1GoalPosition, level1CameraPosition);

        //Level 2
        //Level 2 Ground
        int[,] level2Ground = new int[,]{
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


        //Level 2 Path
        /*
         *                         {
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {x,x,x,x,x,x,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,x,x,x,x,x,x,x,x},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                    };
         */

        Vector2[] level2Path = new Vector2[]{
                                    new Vector2(0, -1),
                                    new Vector2(1, -1),
                                    new Vector2(2, -1),
                                    new Vector2(3, -1),
                                    new Vector2(4, -1),
                                    new Vector2(5, -1),
                                    new Vector2(6, -1),
                                    new Vector2(6, -2),
                                    new Vector2(6, -3),
                                    new Vector2(6, -4),
                                    new Vector2(6, -5),
                                    new Vector2(6, -6),
                                    new Vector2(6, -7),
                                    new Vector2(6, -8),
                                    new Vector2(7, -8),
                                    new Vector2(8, -8),
                                    new Vector2(9, -8),
                                    new Vector2(10, -8),
                                    new Vector2(11, -8),
                                    new Vector2(12, -8),
                                    new Vector2(13, -8)
                                   };

        //Level 2 Ennemies

        int[,] level2Ennemies = new int[,]{
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,1,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,2,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,1,0,0,0,0,0,0,0,0},
                                    {0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                                    };

        //Level 2 Start Position
        Vector2 level2StartPosition = new Vector2(0, -1);

        //Level 2 Goal Position
        Vector2 level2GoalPosition = new Vector2(13, -8);

        //Level 2 Camera Position
        Vector2 level2CameraPosition = new Vector2(6.5f, -4.5f);

        NewLevel(level2Ground, level2Path, level2Ennemies, level2StartPosition, level2GoalPosition, level2CameraPosition);
    }

    private void NewLevel(int[,] ground, Vector2[] path, int[,] ennemies, Vector2 start, Vector2 goal, Vector2 camPosition)
    {        
        //Creation of a new Level
        Level level = new Level();
        level.SetLevelGround(ground);
        level.SetLevelPath(path);
        level.SetLevelEnnemies(ennemies);
        level.SetStartPosition(start);
        level.SetGoalPosition(goal);
        level.SetCameraPosition(camPosition);
               
        //Add this level to the level list
        levelList.Add(level);
        
    }

    public ArrayList GetLevelList()
    {
        return levelList;
    }

}
