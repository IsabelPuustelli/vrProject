using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverInteractable : MonoBehaviour
{
    private bool inHand = false;
    private Vector3 startingPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    void Update() 
    {
        if (inHand == false)
        {
            transform.position = startingPos;
        }    
    }

    public void grabbed()
    {
        inHand = true;
    }
    public void released()
    {
        inHand = false;
    }
}
