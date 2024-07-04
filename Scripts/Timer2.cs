using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{

    public float targetTime = 15.0f;

void Update(){

    targetTime -= Time.deltaTime;

    if (targetTime <= 0.0f)
        {
        timerEnded();
        }

}

void timerEnded()
{
   SceneManager.LoadScene(2);
}


}