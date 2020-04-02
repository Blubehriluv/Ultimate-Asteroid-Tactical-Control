using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDTracker : MonoBehaviour
{

    public Text enemiesLeftNumber;
    public Text eliminationNumber;
    public Text livesNumber;
    private string entHolder;
    private string killedHolder;
    private string lifeHolder;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {

        entHolder =  VariableHolder.totalEntities.ToString();
        enemiesLeftNumber.text = entHolder;

        killedHolder = DeathCount.TotalKilledByPlayer.ToString();
        eliminationNumber.text = killedHolder;

        lifeHolder = VariableHolder.playerLives.ToString();
        livesNumber.text = lifeHolder;
    }
}
    