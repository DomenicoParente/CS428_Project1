using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

public class magicballScript : MonoBehaviour
{
    public GameObject magicBallText;

    static System.Random randomObject = new System.Random();

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void reply()
    {
        int randomNumber = randomObject.Next(19);
        switch (randomNumber)
        {
            case 1:
                {
                    Console.WriteLine("It is Certain");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("It is decidedly so");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Without a doubt");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Yes definitely");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("You may rely on it");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("As I see it, yes.");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Most likely");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Outlook good");
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Yes");
                    break;
                }
            case 10:
                {
                    Console.WriteLine("Signs point to yes");
                    break;
                }
            case 11:
                {
                    Console.WriteLine("Reply hazy, try again");
                    break;
                }
            case 12:
                {
                    Console.WriteLine("Ask again later");
                    break;
                }
            case 13:
                {
                    Console.WriteLine("Better not tell you now");
                    break;
                }
            case 14:
                {
                    Console.WriteLine("Cannot predict now");
                    break;
                }
            case 15:
                {
                    Console.WriteLine("Concentrate and ask again");
                    break;
                }
            case 16:
                {
                    Console.WriteLine("Don't count on it");
                    break;
                }
            case 17:
                {
                    Console.WriteLine("My reply is no");
                    break;
                }
            case 18:
                {
                    Console.WriteLine("My sources say nod");
                    break;
                }
            case 19:
                {
                    Console.WriteLine("Outlook not so good");
                    break;
                }
            case 20:
                {
                    Console.WriteLine("Very doubtful");
                    break;
                }
        }

    }
}
