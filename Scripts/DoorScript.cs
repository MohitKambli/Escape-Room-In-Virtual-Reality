using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    Animator animator;
    //public bool keyStatus;
    private GameObject _mug;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    [SerializeField]
    private string sceneNametoLoad;
    private GameObject _player;
    private float score;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        _mug = GameObject.FindGameObjectWithTag("Mug");
        _player = GameObject.FindGameObjectWithTag("Player");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // print(other.gameObject.name);
        print(_mug);
        if (_mug != null)
        {
            print(_mug.GetComponent<Key>().keyfound);
            if (other.gameObject.name == "Player" && _mug.GetComponent<Key>().keyfound == true)
            {
                // print(other.gameObject.name);
                //print("Enter");
                score=_player.GetComponent<Score>().score;
                  Score.total_score=Score.total_score+score;
                  print("Total Score"+score);
                animator.SetTrigger("OpenDoor");
                audio.PlayOneShot(SoundToPlay, Volume);

            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" && _mug.GetComponent<Key>().keyfound == true)
        {
          //  print("Exit");
            animator.SetTrigger("CloseDoor");
            animator.enabled = true;
            SceneManager.LoadScene(sceneNametoLoad);
        }
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
    }

}
