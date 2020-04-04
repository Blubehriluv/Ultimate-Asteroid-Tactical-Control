using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarTransfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseTargeters()
    {
        VariableHolder.targeter_amount += 1;
        VariableHolder.totalEntities += 1;
    }
    public void DecreaseTargeters()
    {
        VariableHolder.targeter_amount -= 1;
        VariableHolder.totalEntities -= 1;
    }

    public void IncreaseFloaters()
    {
        VariableHolder.floater_amount += 1;
        VariableHolder.totalEntities += 1;
    }
    public void DecreaseFloaters()
    {
        VariableHolder.floater_amount -= 1;
        VariableHolder.totalEntities -= 1;
    }

    public void IncreaseRotationSpeed()
    {
        VariableHolder.playerRotationSpeed += 5;
    }
    public void DecreaseRotationSpeed()
    {
        VariableHolder.playerRotationSpeed -= 5;
    }

    public void IncreasePlayerSpeed()
    {
        VariableHolder.playerSpeed += 1;
    }
    public void DecreasePlayerSpeed()
    {
        VariableHolder.playerSpeed -= 1;
    }

    public void IncreasePlayerLives()
    {
        VariableHolder.playerLives += 1;
    }
    public void DecreasePlayerLives()
    {
        VariableHolder.playerLives -= 1;
    }

    public void IncreaseBulletSpeed()
    {
        VariableHolder.bulletSpeed += 1f;
    }
    public void DecreaseBulletSpeed()
    {
        VariableHolder.bulletSpeed -= 1f;
    }

    public void IncreaseFloaterSpeed()
    {
        VariableHolder.floaterSpeed += 1;
    }
    public void DecreaseFloaterSpeed()
    {
        VariableHolder.floaterSpeed -= 1;
    }

    public void IncreaseTargeterSpeed()
    {
        VariableHolder.targeterSpeed += 1;
    }
    public void DecreaseTargeterSpeed()
    {
        VariableHolder.targeterSpeed -= 1;
    }
}
