using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    float time = 5f;
    void Update()
    {
        Timer();
        NextLevel();
    }

    public void Timer()
    {
        time -= Time.deltaTime;
        Debug.Log(time);
    }

    public void NextLevel()
    {
        if (time <= 0f)
        {
            SceneManager.LoadScene("Ronda2");

        }
    }
}
