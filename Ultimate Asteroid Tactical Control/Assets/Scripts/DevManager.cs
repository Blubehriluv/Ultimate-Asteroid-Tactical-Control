using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevManager : MonoBehaviour
{
    public Text TANumber;
    public Text FANumber;
    public Text TENumber;
    public Text PLNumber;
    public Text PSNumber;
    public Text PRSNumber;
    public Text BSNum;
    public Text TSNUm;
    public Text FSNum;

    private string tanHolder;
    private string fanHolder;
    private string tenHolder;
    private string plnHolder;
    private string psnHolder;
    private string prsHolder;
    private string bsnHolder;
    private string tsnHolder;
    private string fsnHolder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tanHolder = VariableHolder.targeter_amount.ToString();
        TANumber.text = tanHolder;

        fanHolder = VariableHolder.floater_amount.ToString();
        FANumber.text = fanHolder;

        tenHolder = VariableHolder.totalEntities.ToString();
        TENumber.text = tenHolder;

        plnHolder = VariableHolder.playerLives.ToString();
        PLNumber.text = plnHolder;

        psnHolder = VariableHolder.playerSpeed.ToString();
        PSNumber.text = psnHolder;

        prsHolder = VariableHolder.playerRotationSpeed.ToString();
        PRSNumber.text = prsHolder;

        bsnHolder = VariableHolder.bulletSpeed.ToString();
        BSNum.text = bsnHolder;

        tsnHolder = VariableHolder.targeterSpeed.ToString();
        TSNUm.text = tsnHolder;

        fsnHolder = VariableHolder.floaterSpeed.ToString();
        FSNum.text = fsnHolder;
    }
}
