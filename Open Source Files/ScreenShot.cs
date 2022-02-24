using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            string screenShotName;
            int randomNumber = Random.Range(0, 10000);
            screenShotName = "Sword-Fighters" + randomNumber + ".png";
            ScreenCapture.CaptureScreenshot(screenShotName);
        }
    }
}
