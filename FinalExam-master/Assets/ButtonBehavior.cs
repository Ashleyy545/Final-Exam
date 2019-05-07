using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{

    public void goToScores()
    {
        SceneManager.LoadScene(1);
    }

    public void nextButton()
    {
        SceneManager.LoadScene(2);
    }

    public void exitScreen()
    {
        SceneManager.LoadScene(3);
    }

    public void goAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void stop()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }



}
