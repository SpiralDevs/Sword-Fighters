using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UrlOpener : MonoBehaviour
{
    public string Url; // this is the line where you would put in your url in unity
    public void OpenURL() // this is the OnClick() event
    {
        Application.OpenURL(Url); // this is refering to line 6 to open the url stated in unity
        Debug.Log("URL Opened!!!"); // this is declaring in the console that the url has been opened
    }
}