using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeveloper : MonoBehaviour
{
    private bool isActive;
    public GameObject IncreaseAdjustments;
    public GameObject DecreaseAdjustments;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (isActive == false)
        {
            IncreaseAdjustments.SetActive(true);
            DecreaseAdjustments.SetActive(true);
            isActive = true;
        }
        else if (isActive == true)
        {
            IncreaseAdjustments.SetActive(false);
            DecreaseAdjustments.SetActive(false);
            isActive = false;
        }
    }
}
