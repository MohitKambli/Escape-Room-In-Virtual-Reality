using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private GameObject key, address, ip, particle;
    public static bool keyfound = false;
    public int fontSize = 40;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        key = GameObject.FindGameObjectWithTag("KeyTag");
        address = GameObject.FindGameObjectWithTag("KeyAddress");
        ip = GameObject.FindGameObjectWithTag("ip");
        particle = GameObject.FindGameObjectWithTag("Particle");
        address.SetActive(false);
        ip.SetActive(false);
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
            address.SetActive(true);
            ip.SetActive(true);
            key.SetActive(false);
            Destroy(particle);
            Destroy(key);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
        {
            print("Key Not Found");
        }
    }
    
}
