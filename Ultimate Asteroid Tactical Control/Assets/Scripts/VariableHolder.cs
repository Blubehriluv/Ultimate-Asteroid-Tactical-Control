using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableHolder : MonoBehaviour
{
    public static int targeter_amount;

    public static int floater_amount;

    public static int totalEntities;

    public static int playerLives;

    public static int playerSpeed;

    public static float playerRotationSpeed;

    public static float bulletSpeed;

    public static int targeterSpeed;

    public static int floaterSpeed;
    // Start is called before the first frame update
    void Start()
    {
        targeter_amount = 10;
        floater_amount = 10;
        totalEntities = targeter_amount + floater_amount;
        playerRotationSpeed = 150;
        playerSpeed = 15;
        playerLives = 3;
        bulletSpeed = 0.5f;
        targeterSpeed = 15;
        floaterSpeed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseTargeters()
    {
        targeter_amount += 1;
        totalEntities += 1;
    }
    public void DecreaseTargeters()
    {
        targeter_amount -= 1;
        totalEntities -= 1;
    }

    public void IncreaseFloaters()
    {
        floater_amount += 1;
        totalEntities += 1;
    }
    public void DecreaseFloaters()
    {
        floater_amount -= 1;
        totalEntities -= 1;
    }

    public void IncreaseRotationSpeed()
    {
        playerRotationSpeed += 5;
    }
    public void DecreaseRotationSpeed()
    {
        playerRotationSpeed -= 5;
    }

    public void IncreasePlayerSpeed()
    {
        playerSpeed += 1;
    }
    public void DecreasePlayerSpeed()
    {
        playerSpeed -= 1;
    }

    public void IncreasePlayerLives()
    {
        playerLives += 1;
    }
    public void DecreasePlayerLives()
    {
        playerLives -= 1;
    }

    public void IncreaseBulletSpeed()
    {
        bulletSpeed += .1f;
    }
    public void DecreaseBulletSpeed()
    {
        bulletSpeed -= .1f;
    }

    public void IncreaseFloaterSpeed()
    {
        floaterSpeed += 1;
    }
    public void DecreaseFloaterSpeed()
    {
        floaterSpeed -= 1;
    }

    public void IncreaseTargeterSpeed()
    {
        targeterSpeed += 1;
    }
    public void DecreaseTargeterSpeed()
    {
        targeterSpeed -= 1;
    }
}
