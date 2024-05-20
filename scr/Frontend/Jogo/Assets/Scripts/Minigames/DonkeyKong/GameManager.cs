using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text vidasTxt;
    private static int level;
    public static int lives = 2;
    //private int score;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        NewGame();
        vidasTxt.text = lives.ToString();
    }

    private void NewGame()
    {
        lives = 2;
       // score = 0;

        SceneManager.LoadScene("DonkeyKongRules"); //muda cena
    }

    /*
    private void LoadLevel(int index)
    {
        level = index;

        Camera camera = Camera.main;

        if (camera != null )
        {
            camera.cullingMask = 0;
        }

        Invoke(nameof(LoadScene), 1f);
    
    }
    */

    /*
    private void LoadScene()
    {
        SceneManager.LoadScene(level);
    }
    */
    
    public void LevelComplete()
    {
        SceneManager.LoadScene("Cidade");
        MudarCena.ObjetivoConcluido();
    }
    

    public void LevelFailed()
    {
        lives--;
        vidasTxt.text = lives.ToString();

        if (lives <= 0)
        {
            SceneManager.LoadScene("Derrota"); 
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        } 
        
        else
        {
            SceneManager.LoadScene("Donkey");
        }
    }
}
