using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorC : MonoBehaviour
{
    public int timeLeft = 14;
    public int timeLeftGameOver = 5;
    private GameObject floor, player;
    public static bool doorOpen = false;
    Animator animator;
    public AudioClip SoundToPlay;//, CrackSound;
    AudioSource audio;//, audioCrack;
    public float Volume;//, CrackVolume;
    [SerializeField]
    private string sceneNametoLoad;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        floor = GameObject.FindGameObjectWithTag("Floor");
        audio = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        //audioCrack = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            Destroy(floor);
            StartCoroutine("GameOverTime");
            if (timeLeftGameOver <= 0 && doorOpen == true && player.transform.position.y < -1f)
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
            animator.SetTrigger("OpenDoor");
            audio.PlayOneShot(SoundToPlay, Volume);
            doorOpen = true;
            //audioCrack.PlayOneShot(CrackSound, CrackVolume);
            StartCoroutine("LoseTime");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player" &&  KeyScript.keyfound == true)
        {
            animator.SetTrigger("CloseDoor");
            animator.enabled = true;
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
