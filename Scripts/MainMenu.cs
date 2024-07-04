using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///Source:https://www.youtube.com/watch?v=-GWjA6dixV4


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
  {
    SceneManager.LoadScene(7);
  }

    public void QuitGame()
    {
        Application.Quit();
    }

}
