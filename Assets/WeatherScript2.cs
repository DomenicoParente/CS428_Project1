using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;

public class WeatherScript2 : MonoBehaviour
{
    public GameObject weatherTextObject;
    // add your personal API key after APPID= and before &units=
    string url = "https://api.openweathermap.org/data/2.5/weather?lat=40.730610&lon=-73.935242&APPID=cf2100a3875bf18eb092ccf3451fde95&units=imperial";


    void Start()
    {

        // wait a couple seconds to start and then refresh every 900 seconds

        InvokeRepeating("GetDataFromWeb", 2f, 900f);
    }

    void GetDataFromWeb()
    {

        StartCoroutine(GetRequest(url));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();


            if (webRequest.isNetworkError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the weather data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);


                var stringAPI = webRequest.downloadHandler.text;
                int first = stringAPI.IndexOf("temp");
                int second = stringAPI.IndexOf("feels_like");
                string trimTemp = stringAPI.Substring(first, second - first);
                string temp = trimTemp.Trim('t', 'e', 'm', 'p', ',', ':', '"', ':', ',');
                int startConditions = webRequest.downloadHandler.text.IndexOf("main", 0);
                int endConditions = webRequest.downloadHandler.text.IndexOf(",", startConditions);
                string conditions = webRequest.downloadHandler.text.Substring(startConditions + 7, (endConditions - startConditions - 8));

                weatherTextObject.GetComponent<TextMeshPro>().text = "" + temp.ToString() + "°F\n" + conditions;
            }
        }
    }
}


