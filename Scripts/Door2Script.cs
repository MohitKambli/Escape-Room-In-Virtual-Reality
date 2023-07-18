using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door2Script : MonoBehaviour
{
  Animator animator;
  //public bool keyStatus;
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
      //key = GameObject.FindGameObjectWithTag("Key2");
      audio = GetComponent<AudioSource>();
      _player = GameObject.FindGameObjectWithTag("Player");
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
          if (other.gameObject.name == "Player" && Key2.keyfound == true)
          {
          //  print(Key2.keyfound);
          //  print("Enter");
          score=_player.GetComponent<Score>().score;
              Score.total_score=Score.total_score+score;
            print("Total Score"+score);
              animator.SetTrigger("OpenDoor");
              audio.PlayOneShot(SoundToPlay, Volume);

          }
  }

  void OnTriggerExit(Collider other)
  {
      if (other.gameObject.name == "Player" && Key2.keyfound == true)
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
