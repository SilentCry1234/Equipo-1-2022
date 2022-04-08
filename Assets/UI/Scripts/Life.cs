using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public static int vidas = 3;
    public int vidaa;
    public bool takeDamage;
    public float time;
    
    public GameObject lost;

    public bool isDead;

    public static Life instance; 

    public AudioSource corte; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if( instance != this )
        {
            Destroy(instance.gameObject);
            instance = this; 
        }
    }

    private void Update()
    {
        if(takeDamage == false)
        {
            Timer();
        } 

        if (time >= 3f)
        {
            takeDamage = true;
            time = 0f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (takeDamage == true)
        {
            if (collision.gameObject.CompareTag("Enemigo"))
            {
                vidas -= 1;
                corte.Play(); 
                Contenedorr.contenedores.ReducirVida();
            }
            if (vidas <= 0)
            {
                isDead = true;
                StartCoroutine(CartelMuerte());
            }
        }
        takeDamage = false;
    }

    public void Timer()
    {
        time += Time.deltaTime;
    }

    IEnumerator CartelMuerte()
    {
        if (isDead)
        {
            Time.timeScale = 0;
            lost.SetActive(true);

            AudioManager.instance.backgroundGamePlay.Stop();

            while (lost.GetComponent<CanvasGroup>().alpha < 1f)
            {
                lost.GetComponent<CanvasGroup>().alpha += 0.005f;
                yield return new WaitForSecondsRealtime(0.01f);
            }
        }
    }
}
