using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorA : MonoBehaviour
{
    private static GameObject player;
    public static bool doorOpen = false;
    Animator animator;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    [SerializeField]
    private string sceneNametoLoad;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        //audioFire = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -0.6f && doorOpen == true)
        {
            SceneManager.LoadScene(sceneNametoLoad);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            animator.SetTrigger("OpenDoor");
            audio.PlayOneShot(SoundToPlay, Volume);
            //audioFire.PlayOneShot(FireSound, FireVolume);
            doorOpen = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            animator.SetTrigger("CloseDoor");
            animator.enabled = true;
        }
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
    }
}
