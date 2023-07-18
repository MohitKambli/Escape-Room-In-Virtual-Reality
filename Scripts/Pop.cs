using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ball1;
    private GameObject ball2;

    //private GameObject _player;
    public static int number_of_blue_ball_found=0;
    public int fontSize = 40;
    public AudioClip SoundToPlay;
    AudioSource audio;
    public float Volume;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        ball1 = GameObject.FindGameObjectWithTag("BlueBall1");
        ball2 = GameObject.FindGameObjectWithTag("BlueBall2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player_Collider")
        {
            // print(other.gameObject.name);
            print("Ball Found");
            if(number_of_blue_ball_found==0)
              Destroy(ball2);
            else if(number_of_blue_ball_found==1)
              Destroy(ball1);
            number_of_blue_ball_found=+1;
            print(number_of_blue_ball_found);
            audio.PlayOneShot(SoundToPlay, Volume);
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
