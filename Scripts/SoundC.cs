using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundC : MonoBehaviour
{
    public AudioClip CrackSound;
    AudioSource audioCrack;
    public float CrackVolume;
    // Start is called before the first frame update
    void Start()
    {
        audioCrack = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(DoorC.doorOpen == true)
        {
            audioCrack.PlayOneShot(CrackSound, CrackVolume);
        }
    }
}
