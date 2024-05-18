using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{

    public TMP_Text score;
    public GameObject historia;
    public GameObject objetivoControles;
    public static int lixoColetado = 0;
    public static bool funcaoChamada = false;
    private IEnumerator coroutine;



    private void Start()
    {
      StartCoroutine(PausaPonto());
    }


    private void Update()
    {
        
    }

    private IEnumerator PausaPonto()
    {
           score.SetText(lixoColetado.ToString());
           yield return new WaitUntil(() => funcaoChamada == true);
    }


    public void MiniGameFlappyBird()
    {
       
        SceneManager.LoadScene("Flappy");
    }
    
    public void MiniGameFlappyBirdRules()
    {
        SceneManager.LoadScene("FlappyBirdRules");
        //Deixa o cursor visível
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public static void MiniGameDonkeyKong()
    {
        SceneManager.LoadScene("Donkey");
    }

    public void MiniGameDonkeyKongRules()
    {
        SceneManager.LoadScene("Preload");
        //Deixa o cursor visível
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MiniGameFruitNinjaRules()
    {
        SceneManager.LoadScene("FruitNinjaRules");
        //Deixa o cursor visível
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MiniGameReciclandoRules()
    {
        SceneManager.LoadScene("SeparandoOsLixosGameRules");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public static void MainGameCidade()
    {
       
        funcaoChamada = false;
        SceneManager.LoadScene("Cidade");
        PlayerPrefs.GetFloat("Timer.timeLeft");
        PlayerPrefs.GetFloat("score");

    }

    public void VoltaProMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void ObjetivoConcluido()
    {
       
        funcaoChamada = true;
        lixoColetado++;
        PlayerPrefs.SetInt("score", lixoColetado);
        MainGameCidade();
    }

    public static void ObjetivoNaoConcluido()
    {
        
        SceneManager.LoadScene("Derrota");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void SalvarVariaveis()
    {
        PlayerPrefs.SetInt("score", lixoColetado);
    }

    public static void TimeOut()
    {
        
        SceneManager.LoadScene("TimeOut");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ComoJogarGameRules()
    {
        historia.SetActive(false);
        objetivoControles.SetActive(true);
    }

    public void VoltarGameRules()
    {
        historia.SetActive(true);
        objetivoControles.SetActive(false);

    }
   


}
