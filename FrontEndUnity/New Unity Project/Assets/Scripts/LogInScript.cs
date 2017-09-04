using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LitJson;
using System.Text;
using System.Collections.Generic;

public class LogInScript : MonoBehaviour
{

    string CreateAccountURL = "http://localhost:2000/....";


    //===Login Scherm===
    public InputField username;
    public InputField password;

    //===Login knop check===
    public void logIn()
    {
        if (username.text.Length > 0 && password.text.Length > 0)
        {

            // WWWForm form = new WWWForm();
            // form.AddField("username", username.text);
            // form.AddField("password", password.text);

            string json = "{\"username\": \"" + username.text + "\", \"password\": \"" + password.text + "\"}";
            byte[] body = Encoding.UTF8.GetBytes(json);

			
			Dictionary<string, string> headers = new Dictionary<string, string>();
			headers.Add("Content-Type", "application/json");

            CreateAccountURL = "http://localhost:2000/userLogIn";
            WWW www = new WWW(CreateAccountURL, body, headers);
			StartCoroutine(WaitForLoginRequest(www));
        }
        else
        {
            print("please fill in log in info");
        }

    }

    //===Create account===
    public void CreateUser()
    {
        // WWWForm form = new WWWForm();                           //Creer nieuw formulier die je in php script kan aanleveren
        // form.AddField("usernamePost", username);                //Add nieuw field, en fieldname is usernamePost(Zoals in PHP script is aangemaakt) en dan username is de string die de user zometeen invoert.
        // form.AddField("passwordPost", password);

        WWW www = new WWW(CreateAccountURL);              //connect met deze URL en connect het formulier dat we zojuist hierboven hebben aangemaakt eraan
        //StartCoroutine(WaitForRequest(www));
    }

    private IEnumerator WaitForLoginRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            userDataSingleton.setUser(username.text);
			Application.LoadLevel("home");
            // JsonData test = JsonMapper.ToObject(www.text);
            // print(test["status"]);

        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

}
