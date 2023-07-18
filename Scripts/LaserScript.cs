using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    private GameObject _player;
    private bool _collidedWithPlayer = false;
    //public ParticleSystem ps;
    //public ParticleSystem part;
    //int numCollisionEvents = 0;
    //public List<ParticleCollisionEvent> collisionEvents;

    // Start is called before the first frame update

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        //part = GetComponent<ParticleSystem>();
        //collisionEvents = new List<ParticleCollisionEvent>();

    }

    // Update is called once per frame
    void Update()
    {
        if(KeyScript.keyfound == false)
        {
            if (_player.transform.position.x >= -70f && _player.transform.position.x <= -67f &&
            _player.transform.position.z >= -5f && _player.transform.position.z <= 4f)
            {
                _collidedWithPlayer = true;
                Attack();
            }
        }
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
