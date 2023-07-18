using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2 : MonoBehaviour
{
  // Start is called before the first frame update
  private GameObject key;
  //private GameObject _player;
  public static bool keyfound=false;
  public int fontSize = 40;
  public AudioClip SoundToPlay;
  AudioSource audio;
  public float Volume;

  void Start()
  {
      // _player = GameObject.FindGameObjectWithTag("Player");
      audio = GetComponent<AudioSource>();
      key = GameObject.FindGameObjectWithTag("Key2");
        
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
      print(other.gameObject.name);
      if ((other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider") && Push.keepcount == 3)
      {
          print("Key Found");
            keyfound = true;
            audio.PlayOneShot(SoundToPlay, Volume);
            
        }
  }

  void OnTriggerExit(Collider other)
  {
      if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
      {
          print("Key Not Found");
            Destroy(key);
        }
    }

    internal void SetActive(bool v)
    {
        throw new NotImplementedException();
    }
}
