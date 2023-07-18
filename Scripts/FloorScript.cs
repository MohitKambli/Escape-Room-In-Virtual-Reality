using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorScript : MonoBehaviour
{
    private GameObject floor;
    [SerializeField]
    private string sceneNametoLoad;
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.FindGameObjectWithTag("FireFloor");
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
            SceneManager.LoadScene(sceneNametoLoad);
        }
    }
}
