using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenSwitch : MonoBehaviour
{
    public GameObject container;
    public GameObject attachPoint;
    // Start is called before the first frame update
    void Start()
    {
        container.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.eulerAngles.y < 100 && container.activeInHierarchy == false) {container.SetActive(true); Debug.Log(transform.rotation.eulerAngles.z);}
        
        transform.LookAt(attachPoint.transform.position);

        var temp = transform.rotation.eulerAngles;
        Debug.Log("X: " + temp.x + "   Y: " + temp.y + "   Z: " + temp.z);
    }
}
