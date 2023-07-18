using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4InRoom3 : MonoBehaviour
{
    Animator animator;
    //public bool keyStatus;
    public AudioClip SoundToPlay;
    AudioSource audio;
    Animation animation;
    public float Volume;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animation = GetComponent<Animation>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            animation["Door4Animation"].wrapMode = WrapMode.Once;
            animation.Play("Door4Animation");
            audio.PlayOneShot(SoundToPlay, Volume);
        }
    }
    void PauseAnimationEvent()
    {
        animation.enabled = false;
    }
}
