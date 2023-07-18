using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
  private GameObject ball1;
  private GameObject ball2;
  private GameObject ball3;

  private GameObject ballcopy;
  private GameObject key;
  public int number_of_ball_found=0;
  public int fontSize = 40;
  public float y=0;
  public AudioClip SoundToPlay;
  AudioSource audio;
  public float Volume;
  public static int keepcount=0;
  public int iteration=1;
    //private float speed = 1;
    //private Vector3 target = new Vector3(-52f, -1.1f, -1f);

  void Start()
  {
        audio = GetComponent<AudioSource>();
        ball1 = GameObject.FindGameObjectWithTag("RedBall1");
        ball2 = GameObject.FindGameObjectWithTag("RedBall2");
        ball3 = GameObject.FindGameObjectWithTag("RedBall3");
        ballcopy = GameObject.FindGameObjectWithTag("RedBall4");
        key = GameObject.FindGameObjectWithTag("Key2");
        key.SetActive(false);
    }

  // Update is called once per frame
  void Update()
  {
        //print(Push.keepcount);
        
        print(iteration);
    if(Push.keepcount==3 && iteration==1){
      print("Key Visible");
            key.SetActive(true);
            //key.transform.position = new Vector3(-45f, 0f, 0f);
            //key.transform.position.Set(-52f, -1.1f, -1f);// = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
            //GameObject b=Instantiate(key,new Vector3(-46.08f,0.0f,0.9f),Quaternion.identity) as GameObject;
      iteration=0;
    }
  }

  void OnTriggerEnter(Collider other)
  {
      print(other.gameObject.name);
      if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
      {
          // print(other.gameObject.name);
          print("Ball Found");
          print(PickRed.ballfound);
          print(Pop.number_of_blue_ball_found);
          if(PickRed.ballfound==1 && Pop.number_of_blue_ball_found==1){
            GameObject a=Instantiate(ballcopy,new Vector3(-37.51f,(0.3f+y),-4.44f),Quaternion.identity) as GameObject;
            print("Instantiate");
            PickRed.ballfound-=1;
            y=y+0.3f;
            keepcount+=1;
          }

          else if(PickRed.ballfound==0){
            //
          }


      }
  }

  void OnTriggerExit(Collider other)
  {
      if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
      {
          print("Key Not Found");
      }
      /*if (keepcount == 3)
        {
            key.transform.TransformVector(-46.08f, 0.0f, 0.9f);
        }*/
  }
}
