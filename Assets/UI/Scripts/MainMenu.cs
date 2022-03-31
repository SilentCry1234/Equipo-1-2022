using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playGame;
    void Start()
    {
        playGame.onClick.AddListener(StartGame);
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
