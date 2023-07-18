using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundB : MonoBehaviour
{
    public AudioClip GoodSound;
    AudioSource audioGood;
    public float GoodVolume;
    // Start is called before the first frame update
    void Start()
    {
        audioGood = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorB.doorOpen == true)
        {
            audioGood.PlayOneShot(GoodSound, GoodVolume);
        }
    }
}
