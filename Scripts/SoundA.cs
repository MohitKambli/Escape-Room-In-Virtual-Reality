using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundA : MonoBehaviour
{
    public AudioClip FireSound;
    AudioSource audioFire;
    public float FireVolume;
    // Start is called before the first frame update
    void Start()
    {
        audioFire = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorA.doorOpen == true)
        {
            audioFire.PlayOneShot(FireSound, FireVolume);
        }
    }
}
