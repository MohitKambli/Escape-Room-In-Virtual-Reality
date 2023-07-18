using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalKey : MonoBehaviour
{
    private GameObject key;
    public static bool keyfound = false;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        key = GameObject.FindGameObjectWithTag("FinalKey");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
        {
            // print(other.gameObject.name);
            print("Key Found");
            keyfound = true;
            audio.PlayOneShot(SoundToPlay, Volume);
            Destroy(key);
        }
    }
}
