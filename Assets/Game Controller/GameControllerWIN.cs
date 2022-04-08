using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerWIN : MonoBehaviour
{
    [SerializeField] private int NumeroEscena;

    float time = 10f;
    void Update()
    {
        Timer();
        NextLevel();
    }

    public void Timer()
    {
        time -= Time.deltaTime;
    }

    public void NextLevel()
    {
        if (time <= 0f)
        {
            SceneManager.LoadScene(NumeroEscena);
        }
    }
}
