using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider HealthBar;
    public float Health = 100;
    private float _currentHealth;
    [SerializeField]
    private string sceneNametoLoad;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = Health;
    }

    // Update is called once per frame
    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
        if (_currentHealth <= 0)
        {
            SceneManager.LoadScene(sceneNametoLoad);
        }
    }

    public float getHealth()
    {
        return _currentHealth;
    }
}
