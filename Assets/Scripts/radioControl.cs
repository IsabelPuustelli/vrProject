using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radioControl : MonoBehaviour
{
    Vector3 On;
    Vector3 Off;
    bool play = false;
    AudioSource radioAudio;
    float volume;

    // Start is called before the first frame update
    void Start()
    {
        Off = transform.position;
        On = transform.position; On.x -= 0.35f;
        radioAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Off.x) {transform.position = Off;}
        if (transform.position.x < On.x) {transform.position = On;}

        if (transform.position.x < Off.x && play == false)
        {
            play = true; 
            radioAudio.Play();
        }

        volume = (transform.position.x - Off.x) * -1;
        volume = volume / 0.35f;
        radioAudio.volume = volume;
    }
}