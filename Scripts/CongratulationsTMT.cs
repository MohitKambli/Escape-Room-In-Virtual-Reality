using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CongratulationsTMT : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.text = "Congratulations " + AlphabetsDisplay.username + "!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
