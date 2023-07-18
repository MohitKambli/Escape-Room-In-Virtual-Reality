using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieDamage : MonoBehaviour
{
    private Animator _animator;
    private GameObject _player;
    private bool _collidedWithPlayer;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        //print(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            print(other.gameObject.name);
            _animator.SetBool("IsNearPlayer", true);
            print("enter trigger with _player");
        }
    }
        

    void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
        if (other.gameObject.name == "Player_Collider" || other.gameObject.name == "Player")//Capsule of Zombie
        {
          // print(other.gameObject.name);
            _collidedWithPlayer = true;
           Attack();
        }
        //Attack();
        print("enter collided with _player");
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Player_Collider" || other.gameObject.name == "Player")//Capsule
        {
            _collidedWithPlayer = false;
        }
        print("exit collided with _player");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _player)
        {
            _animator.SetBool("IsNearPlayer", false);
        }
        print("exit trigger with _player");
    }
    
    private void Attack()
    {
       // _player.GetComponent<PlayerHealth>().TakeDamage(20);
        if (_collidedWithPlayer)
        {
            _player.GetComponent<PlayerHealth>().TakeDamage(2);
        }
    }

}
