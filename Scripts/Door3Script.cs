using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door3Script : MonoBehaviour
{
    Animator animator;
  //public bool keyStatus;
  public AudioClip SoundToPlay;
  AudioSource audio;
  public float Volume;
    private GameObject _player;
    private float score;
    [SerializeField]
    private string sceneNametoLoad;

    // Start is called before the first frame update
    void Start()
  {
      animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        _player = GameObject.FindGameObjectWithTag("Player");
    }

  // Update is called once per frame
  void Update()
  {

  }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneNametoLoad);
        // Code to execute after the delay
    }

    void OnTriggerEnter(Collider other)
  {
          if (other.gameObject.name == "Player" && FinalKey.keyfound == true)
          {
            score = _player.GetComponent<Score>().score;
            Score.total_score = Score.total_score + score;
            print("Total Score" + score);
            animator.SetTrigger("OpenDoor");
              audio.PlayOneShot(SoundToPlay, Volume);
            StartCoroutine(ExecuteAfterTime(3));
        }
  }

  void OnTriggerExit(Collider other)
  {
      if (other.gameObject.name == "Player" && FinalKey.keyfound == true)
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
