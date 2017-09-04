using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System.Collections.Generic;
using System;

public class LoadAllCards : MonoBehaviour
{

    private List<Card> allCards;

    public jsonToClass jsonConverter;

    // Use this for initialization
    void Start()
    {


        string CreateAccountURL = "http://localhost:2000/getAllCards";
        //string json = "{\"username\": \"" + userDataSingleton.loggedUser + "\"}";
        //byte[] body = Encoding.UTF8.GetBytes(json);


        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/json");

        WWW www = new WWW(CreateAccountURL);
        StartCoroutine(WaitForRequest(www));
    }

    private IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            JsonData allCardsJson = JsonMapper.ToObject(www.text);

            allCards = jsonConverter.setJsonToCard(allCardsJson["value"]);

        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
}
