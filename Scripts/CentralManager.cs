using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralManager : MonoBehaviour
{
    public GameObject gameManagerObject;
    public GameObject powerupManagerObject;
    private GameManager gameManager;
    private PowerUpManager powerUpManager;
    public static CentralManager centralManagerInstance;

    void Awake()
    {
        centralManagerInstance = this;
    }

    void Start()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
        powerUpManager = powerupManagerObject.GetComponent<PowerUpManager>();  
    }

    public void increaseScore()
    {
        gameManager.increaseScore();
    }

    public void damagePlayer()
    {
        gameManager.damagePlayer();
    }
    //Powerup manager
    public void Powerup(){
        powerUpManager.powerup();
    }

    public void consumePowerup(KeyCode k, GameObject g)
    {
        powerUpManager.consumePowerup(k,g);
    }

    public void addPowerup(Texture t, int i, ConsumableInterface c)
    {
        powerUpManager.addPowerup(t,i,c);
    }
}