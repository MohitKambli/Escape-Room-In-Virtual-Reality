﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour
{
    [SerializeField]
    private string sceneNametoLoad;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        
           
        
    }

    void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene(sceneNametoLoad);
    }

    
}
