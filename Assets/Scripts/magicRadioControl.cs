using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class magicRadioControl : MonoBehaviour
{
    Vector3 On;
    Vector3 Off;
    bool play = false;
    AudioSource radioAudio;
    AudioSource otherRadioAudio;
    AudioSource backgroundAudio;
    GameObject map;
    GameObject newMap;
    public Image image;

    float volumeBack;
    float volumeRadio;
    float startVolumeBack;
    float startVolumeRadio;
    float timer = 0;

    // Start is called before the first frame update
    void Awake() 
    {
        image = GetComponent<Image>();
        newMap = GameObject.Find("newMap");
        newMap.SetActive(false);
    }
    void Start()
    {
        Off = transform.position;
        On = transform.position; On.x -= 0.35f;
        radioAudio = GetComponent<AudioSource>();
        backgroundAudio = GameObject.Find("backgroundSound").GetComponent<AudioSource>();
        map = GameObject.Find("Map");
        otherRadioAudio = map.transform.Find("Slider").GetComponent<AudioSource>();
        startVolumeBack = backgroundAudio.volume;
    }

    // Update is called once per frame
    void Update()
    {
        startVolumeRadio = otherRadioAudio.volume;
        if (transform.position.x > Off.x) {transform.position = Off;}
        if (transform.position.x < On.x) {transform.position = On;}

        if (transform.position.x == On.x && play == false)
        {
            play = true;
            backgroundAudio.volume = 0;
            radioAudio.Play();
            map.SetActive(false);
            newMap.SetActive(true);
        }else if (play == false){
            volumeBack = (transform.position.x - Off.x) * -1;
            volumeBack = (volumeBack / 0.35f) + startVolumeBack;
            backgroundAudio.volume = volumeBack;
        }

        if (radioAudio.time > 160)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                var tempColor = image.color;
                tempColor.a += 0.1f;
                image.color = tempColor;
                timer = 0;
            }
        }
    }
}