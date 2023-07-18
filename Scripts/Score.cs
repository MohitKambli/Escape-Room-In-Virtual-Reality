using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
   private GameObject _player;
  public static float total_score=0;
  public float score=0;
  private float startTime;
  private float current_time;
  private float current_health;
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        startTime=Time.time;
    }

    // Update is called once per frame
    void Update()
    {
      current_time=Time.time-startTime;
      current_health=  _player.GetComponent<PlayerHealth>().getHealth();
      score= current_time + (100-current_health);
      //print("Score : "+score);
      //print("TS  : "+total_score);
    //  total_score=total_score+score;
    }
}
