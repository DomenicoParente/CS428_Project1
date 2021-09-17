using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using TMPro;

public class magicballScript : MonoBehaviour
{
    public GameObject magicBallTextObject;
    public GameObject knickknack;
    public AudioSource audioSource;

    static System.Random randomObject = new System.Random();

    public bool x1, x2;

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
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angles = knickknack.transform.rotation.eulerAngles;
        
        if ( x1 == false && x2 == false && ( (angles.x >= -5 && angles.x <= 5) && (angles.z >= -5 && angles.z <= 5) ) )
        {
            x1 = true;
            print("first step");
        }
      
        if (x1 == true && x2 == false && ( (angles.x >= 173 && angles.x <= 180) || (angles.z >= 173 && angles.z <= 180) || (angles.x >= -180 && angles.x <= -173) || (angles.z >= -180 && angles.z <= -173) ))
        {
            x2 = true;
            print("second step");
        }

        if (x2 == true && x1 == true && ( (angles.x >= -5 && angles.x <= 5) && (angles.z >= -5 && angles.z <= 5) ) )
        {
            x1 = false;
            x2 = false;
            reply();
            print("third step");
        }
    }

    void reply()
    {
        int randomNumber = randomObject.Next(19);
        audioSource.Play();
        magicBallTextObject.GetComponent<TextMeshPro>().text = "" + phrases[randomNumber];
    }

}