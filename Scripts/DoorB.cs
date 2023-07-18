using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorB : MonoBehaviour
{
    Animator animator;
    //public bool keyStatus;
    public AudioClip SoundToPlay;//, goodSound;
    public static bool doorOpen = false;
    AudioSource audio;//, audioGood;
    public float Volume;//, goodVolume;
    //[SerializeField]
    //private string sceneNametoLoad;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        //audioGood = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            doorOpen = true;
            animator.SetTrigger("OpenDoor");
            audio.PlayOneShot(SoundToPlay, Volume);
            //audioGood.PlayOneShot(goodSound, goodVolume);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            animator.SetTrigger("CloseDoor");
            animator.enabled = true;
            //SceneManager.LoadScene(sceneNametoLoad);
        }
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
    }
}
