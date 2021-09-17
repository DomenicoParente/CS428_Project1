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

     public bool x1, x2;

    string[] phrases = new string[] {"Certamente",
            "Senza dubbio",
            "Sicuramente si",
            "Certo",
            "Probabilmente",
            "Mi sembra di si",
            "Ci punterei sopra",
            "Chiedi più tardi",
            "Non lo so",
            "Non te lo so dire ora",
            "Concentrati e chiedi di nuovo",
            "Non ci contare",
            "La risposta è no",
            "Credo di no",
            "Non mi sembra buono",
            "Sono  molto dubbioso" };

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

        if (x1 == false && x2 == false && ((angles.x >= -5 && angles.x <= 5) && (angles.z >= -5 && angles.z <= 5)))
        {
            x1 = true;
            print("first step");
        }

        if (x1 == true && x2 == false && ((angles.x >= 173 && angles.x <= 180) || (angles.z >= 173 && angles.z <= 180) || (angles.x >= -180 && angles.x <= -173) || (angles.z >= -180 && angles.z <= -173)))
        {
            x2 = true;
            print("second step");
        }

        if (x2 == true && x1 == true && ((angles.x >= -5 && angles.x <= 5) && (angles.z >= -5 && angles.z <= 5)))
        {
            x1 = false;
            x2 = false;
            reply();
            print("third step");
        }
    }

    void reply()
    {
        int randomNumber = randomObject.Next(16);
        print(phrases[randomNumber].ToString());
        audioSource.Play();
        magicBallTextObject.GetComponent<TextMeshPro>().text = "" + phrases[randomNumber];
    }
}