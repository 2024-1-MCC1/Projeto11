using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditoscodigo : MonoBehaviour
{
    [SerializeField] private string Cidade;
    [SerializeField] private GameObject PainelMenuInicial;
    [SerializeField] private GameObject PainelOpcoes;
    [SerializeField] private GameObject logo;
    public void Jogar()
    {
        MudarCena.lixoColetado = 0;
       // Timer.timeLeft = 300f;
        SceneManager.LoadScene("GameRules");
    }

    public void AbrirOpcoes()
    {
        PainelMenuInicial.SetActive(false);
        logo.SetActive(false);
        PainelOpcoes.SetActive(true);
    }

public void FecharOpcoes()
    {
        PainelOpcoes.SetActive(false);
        PainelMenuInicial.SetActive(true);
        logo.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

}
