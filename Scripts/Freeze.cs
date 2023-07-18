using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Freeze : MonoBehaviour
{
    public int timeLeft = 5;
    public Text countdownText;
    [SerializeField]
    private string sceneNametoLoad;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft.ToString());
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            SceneManager.LoadScene(sceneNametoLoad);
            //countdownText.text = "Times Up!";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            timeLeft--;
        }
    }
}
