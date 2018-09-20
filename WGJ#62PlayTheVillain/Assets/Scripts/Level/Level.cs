using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level  {

    //Attributes
    private int[,] levelGround;

    private Vector2[] levelPath;

    private int[,] levelEnnemies;

    private Vector2 startPosition;
    private Vector2 goalPosition;

    private Vector2 cameraPosition;

    //Constructor
    public Level(){}

    //LevelGround Getter
    public int[,] GetLevelGround()
    {
        return levelGround;
    }

    public void SetLevelGround(int[,] ground)
    {
        levelGround = ground;
    }

    //LevelPath Getter
    public Vector2[] GetLevelPath()
    {
        return levelPath;
    }

    public void SetLevelPath(Vector2[] path)
    {
        levelPath = path;
    }

    //LevelEnnemies Getter
    public int[,] GetLevelEnnemies()
    {
        return levelEnnemies;
    }

    public void SetLevelEnnemies(int[,] ennemies)
    {
        levelEnnemies = ennemies;
    }

    //StartPosition Getter
    public Vector2 GetStartPosition()
    {
        return startPosition;
    }

    public void SetStartPosition(Vector2 position)
    {
        startPosition = position;
    }

    //GoalPosition Getter
    public Vector2 GetGoalPosition()
    {
        return goalPosition;
    }

    public void SetGoalPosition(Vector2 position)
    {
        goalPosition = position;
    }

    //CameraTranslation Getter
    public Vector2 GetCameraPosition()
    {
        return cameraPosition;
    }

    public void SetCameraPosition(Vector2 position)
    {
        cameraPosition = position;
    }

}
