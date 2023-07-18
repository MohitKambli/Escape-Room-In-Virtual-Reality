using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WelcomeUsernameTMT : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.text = AlphabetsDisplay.username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
