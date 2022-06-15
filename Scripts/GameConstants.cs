using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConstants", menuName = "ScriptableObjects/GameConstants", order = 1)]
public class GameConstants : ScriptableObject
{
    int currentScore;
    int currentPlayerHealth;

    public Vector3 gombaSpawnPointStart = new Vector3(2.5f, -0.45f, 0); //test and change?

    public int comsumeTimeStep = 10;
    public double groundSurface = -3.5;
    
    //EnemyController.cs
    public float maxOffset = 5.0f;
    public float enemyPatroltime = 2.0f;
}
