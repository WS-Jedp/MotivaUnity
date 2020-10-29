using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreensFlow : MonoBehaviour
{
    public void goToMenu()
    {
        SceneManager.LoadScene("MainScreen-Menu");
    }

    public void goToMainScreen()
    {
        SceneManager.LoadScene("MainScreen_2ndVersion");
    }
}
