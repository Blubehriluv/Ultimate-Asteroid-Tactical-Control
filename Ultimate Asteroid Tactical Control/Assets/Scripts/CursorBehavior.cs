using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehavior : MonoBehaviour
{
    public GameObject cursor;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = cursor.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnCursor()
    {
        cursor.GetComponent<SpriteRenderer>().enabled = true;
        Debug.Log("The cursor has been turned off");
    }
}
