using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveButton : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneNametoLoad);
        // Code to execute after the delay
    }*/

    public void BackButton()
    {
        //StartCoroutine(ExecuteAfterTime(5));
        SceneManager.LoadScene(sceneToLoad);
    }

    public void PlayButton()
    {
        //StartCoroutine(ExecuteAfterTime(5));
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void InstructionsButton()
    {
        //StartCoroutine(ExecuteAfterTime(5));
        SceneManager.LoadScene(sceneToLoad);
    }

    public void LeaderboardButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
