using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickRed2 : MonoBehaviour
{
  private GameObject ball;

    //private GameObject _player;
    public static int ballfound=0;
    public int fontSize = 40;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;
    //PickRed.ballfound;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        ball = GameObject.FindGameObjectWithTag("RedBall2");
    }

  // Update is called once per frame
  IEnumerator OnTriggerEnter(Collider other)
  {
      print(other.gameObject.name);
      if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
      {
            
            if (PickRed.ballfound ==1 || Pop.number_of_blue_ball_found==0){
            //Go Drop Sound
            //audio.PlayOneShot(SoundToPlay, Volume);
        }
        else if(PickRed.ballfound ==0){
                PickRed.ballfound +=1;
                //redball.SetActive(false);
                //audio = GetComponent<AudioSource>();
                //audio.PlayOneShot(SoundToPlay, Volume);
                //print(SoundToPlay);
                audio.PlayOneShot(SoundToPlay, Volume);
                yield return new WaitForSeconds(0.4f);
                Destroy(ball);
            Debug.Log(PickRed.ballfound);
        }
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
