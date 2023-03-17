using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Telekinesis : MonoBehaviour
{
    bool telekinesisOn = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Ray").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if (telekinesisOn == false && transform.rotation.eulerAngles.z < 295 && transform.rotation.eulerAngles.z > 180)
        {
            telekinesisOn = true;
            Debug.Log("Telekinesis is on!");
            transform.Find("Ray").gameObject.SetActive(true);
        }
        if (telekinesisOn == true && transform.rotation.eulerAngles.z < 180 && transform.rotation.eulerAngles.z > 55)
        {
            telekinesisOn = false;
            Debug.Log("Telekinesis is off");
            transform.Find("Ray").gameObject.SetActive(false);
        }
        /*Debug.Log("X: " + Math.Round(transform.rotation.eulerAngles.x, 2) +
                "  Y: " + Math.Round(transform.rotation.eulerAngles.y, 2) +
                "  Z: " + Math.Round(transform.rotation.eulerAngles.z, 2));*/
    }
}
