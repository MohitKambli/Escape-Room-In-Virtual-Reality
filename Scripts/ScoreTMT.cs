using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTMT : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.text = "Score : " + Score.total_score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
