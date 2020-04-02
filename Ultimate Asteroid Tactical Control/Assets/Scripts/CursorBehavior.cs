using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorBehavior : MonoBehaviour
{
    public GameObject cursor;
    //public EventSystem eventSys;
    
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = cursor.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnOnCursor(BaseEventData eventData)
    {
        cursor.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("The cursor has been turned on");
    }

    public void TurnOffCursor(BaseEventData eventData)
    {
        cursor.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("The cursor has been turned off");
    }
}
