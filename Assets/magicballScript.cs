using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using TMPro;

public class magicballScript : MonoBehaviour
{
    public GameObject magicBallTextObject;

    static System.Random randomObject = new System.Random();

    bool x1, x2, x3;
    bool z1, z2, z3;

    string[] phrases = new string[] {"It is Certain", "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don''t count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful" };

    // Start is called before the first frame update
    void Start()
    {
        x1 = false;
        x2 = false;
        x3 = false;
        z1 = false;
        z2 = false;
        z3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void reply()
    {
        int randomNumber = randomObject.Next(19);
        //magicBallTextObject.GetComponent<TextMeshPro>().text = "" + phrases[randomNumber];
    }
}
