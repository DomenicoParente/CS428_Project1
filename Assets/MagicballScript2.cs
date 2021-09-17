using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using TMPro;

public class MagicballScript2 : MonoBehaviour
{
    public GameObject magicBallTextObject;
    public GameObject knickknack;
    public AudioSource audioSource;

    static System.Random randomObject = new System.Random();

    bool x1, x2;

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
        //Vector3 angles = knickknack.transform.localEulerAngles;
        //print("x:" + angles.x.ToString() + "y:" + angles.y.ToString() + "z:" + angles.z.ToString());
        checkFirst();
        checkSecond();
        checkThird();
    }

    void reply()
    {
        int randomNumber = randomObject.Next(16);
        print(phrases[randomNumber].ToString());
        audioSource.Play();
        magicBallTextObject.GetComponent<TextMeshPro>().text = "" + phrases[randomNumber];
    }

    void checkFirst()
    {
        Vector3 angles = knickknack.transform.localEulerAngles;

        if (x1 == false && x2 == false && (((angles.x >= 0 && angles.x <= 6) || (angles.x >= 355 && angles.x <= 360)) && ((angles.z >= 0 && angles.z <= 6) || (angles.z >= 355 && angles.z <= 360))))
        {
            x1 = true;
            print("first step");
        }
    }

    void checkSecond()
    {
        Vector3 angles = knickknack.transform.localEulerAngles;
        if (x1 == true && x2 == false && (angles.z > 175 && angles.z < 185))
        {
            x2 = true;
            print("second step");
        }
    }

    void checkThird()
    {
        Vector3 angles = knickknack.transform.localEulerAngles;
        if (x1 == true && x2 == true && (((angles.x >= 0 && angles.x <= 6) || (angles.x >= 355 && angles.x <= 360)) && ((angles.z >= 0 && angles.z <= 6) || (angles.z >= 355 && angles.z <= 360))))
        {
            x1 = false;
            x2 = false;
            reply();
            print("third step");
        }
    }
}