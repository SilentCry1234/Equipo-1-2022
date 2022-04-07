using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playGame;
    public Button creditos;
    public Button quit;
    public Button backToMenu;

    void Start()
    {
        playGame.onClick.AddListener(StartGame);
        quit.onClick.AddListener(QuitGame);
    }

    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToMenu()
    {
        AudioManager.instance.backgroundGamePlay.Stop(); 
        SceneManager.LoadScene(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
