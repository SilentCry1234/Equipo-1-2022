using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text tiempo;
    float time = 30f;
    void Update()
    {
        Timer();
        NextLevel();
    }

    public void Timer()
    {
        time -= Time.deltaTime;
        tiempo.text = "" + time.ToString("f0");
    }

    public void NextLevel()
    {
        if (time <= 0f)
        {
            SceneManager.LoadScene("Nivel 2");
        }
    }
}
