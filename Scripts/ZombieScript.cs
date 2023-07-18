using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieScript : MonoBehaviour
{
    /*private Transform goal;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        GetComponent<Animation>().Play("walk");
    }
    void OnTriggerEnter(Collider col)
    {
        GetComponent<CapsuleCollider>().enabled = false;
        Destroy(col.gameObject);
        agent.destination = gameObject.transform.position;
        GetComponent<Animation>().Stop();
        GetComponent<Animation>().Play("back_fall");
        Destroy(gameObject, 6);
        GameObject zombie = Instantiate(Resources.Load("zombie", typeof(GameObject))) as GameObject;
        float randomX = UnityEngine.Random.Range(-12f, 12f);
        float constantY = .01f;
        float randomZ = UnityEngine.Random.Range(-13f, 13f);
        zombie.transform.position = new Vector3(randomX, constantY, randomZ);
        while (Vector3.Distance(zombie.transform.position, Camera.main.transform.position) <= 3)
        {
            randomX = UnityEngine.Random.Range(-12f, 12f);
            randomZ = UnityEngine.Random.Range(-13f, 13f);
            zombie.transform.position = new Vector3(randomX, constantY, randomZ);
        }
    }*/

    public Transform Player;
    float MoveSpeed = 1.6f;
    float MinDist = 2.6f;
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //GetComponent<Animation>().Play("attack 1");
    }
    void LateUpdate()
    {
        //GetComponent<Animation>().Play("walk");
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        /*else
        {
            Vector3 dir = Player.position - transform.position;
            dir.y = 0.0f;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), MoveSpeed * Time.deltaTime);
        }*/
        
    }
}
