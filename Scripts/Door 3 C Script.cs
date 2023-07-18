using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door3CScript : MonoBehaviour
{
    public int timeLeft = 14;
    public int timeLeftGameOver = 5;
    private GameObject floor;
    Animator animator;
    //public bool keyStatus;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    [SerializeField]
    private string sceneNametoLoad;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        floor = GameObject.FindGameObjectWithTag("Floor");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            Destroy(floor);
            StartCoroutine("GameOverTime");
            if (timeLeftGameOver <= 0)
            {
                StopCoroutine("GameOverTime");
                SceneManager.LoadScene(sceneNametoLoad);
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            print(Key2.keyfound);
            print("Enter");
            animator.SetTrigger("OpenDoor");
            audio.PlayOneShot(SoundToPlay, Volume);
            StartCoroutine("LoseTime");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" && KeyScript.keyfound == true)
        {
            print("Exit");

            animator.SetTrigger("CloseDoor");
            animator.enabled = true;
            //SceneManager.LoadScene(sceneNametoLoad);
        }
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            timeLeft--;
        }
    }
    IEnumerator GameOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            timeLeftGameOver--;
        }
    }
}
