using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AlphabetsDisplay : MonoBehaviour
{
    public static string username;
    //public Text inputText;
    public TextMeshProUGUI textmeshPro;
    [SerializeField]
    private string sceneNametoLoad;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject textGO = new GameObject();
        //textmeshPro = GameObject.Find("InputTextMeshPro").GetComponent<TextMeshProUGUI>();
        //inputText = GameObject.Find("InputText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Done()
    {
        SceneManager.LoadScene(sceneNametoLoad);
    }
    public void Backspace()
    {
        username = username.Substring(0, username.Length-1);
        textmeshPro.text = username;
    }
    public void DisplaySpace()
    {
        username += " ";
        textmeshPro.text = username;
    }
    public void DisplayA()
    {
        username += "a";
        textmeshPro.text = username;
    }
    public void DisplayB()
    {
        username += "b";
        textmeshPro.text = username;
    }
    public void DisplayC()
    {
        username += "c";
        textmeshPro.text = username;
    }
    public void DisplayD()
    {
        username += "d";
        textmeshPro.text = username;
    }
    public void DisplayE()
    {
        username += "e";
        textmeshPro.text = username;
    }

    public void DisplayF()
    {
        username += "f";
        textmeshPro.text = username;
    }
    public void DisplayG()
    {
        username += "g";
        textmeshPro.text = username;
    }
    public void DisplayH()
    {
        username += "h";
        textmeshPro.text = username;
    }
    public void DisplayI()
    {
        username += "i";
        textmeshPro.text = username;
    }
    public void DisplayJ()
    {
        username += "j";
        textmeshPro.text = username;
    }
    public void DisplayK()
    {
        username += "k";
        textmeshPro.text = username;
    }
    public void DisplayL()
    {
        username += "l";
        textmeshPro.text = username;
    }
    public void DisplayM()
    {
        username += "m";
        textmeshPro.text = username;
    }
    public void DisplayN()
    {
        username += "n";
        textmeshPro.text = username;
    }
    public void DisplayO()
    {
        username += "o";
        textmeshPro.text = username;
    }
    public void DisplayP()
    {
        username += "p";
        textmeshPro.text = username;
    }
    public void DisplayQ()
    {
        username += "q";
        textmeshPro.text = username;
    }
    public void DisplayR()
    {
        username += "r";
        textmeshPro.text = username;
    }

    public void DisplayS()
    {
        username += "s";
        textmeshPro.text = username;
    }
    public void DisplayT()
    {
        username += "t";
        textmeshPro.text = username;
    }
    public void DisplayU()
    {
        username += "u";
        textmeshPro.text = username;
    }
    public void DisplayV()
    {
        username += "v";
        textmeshPro.text = username;
    }
    public void DisplayW()
    {
        username += "w";
        textmeshPro.text = username;
    }
    public void DisplayX()
    {
        username += "x";
        textmeshPro.text = username;
    }
    public void DisplayY()
    {
        username += "y";
        textmeshPro.text = username;
    }
    public void DisplayZ()
    {
        username += "z";
        textmeshPro.text = username;
    }
}
