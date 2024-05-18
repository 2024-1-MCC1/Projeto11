using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    public GameObject azul;
    public GameObject amarela;
    public GameObject verde;
    public GameObject marrom;
    public GameObject vermelho;

    // Update is called once per frame
    void Update()
    {
        if(azul.activeSelf==true && amarela.activeSelf == true && verde.activeSelf == true && marrom.activeSelf == true && vermelho.activeSelf == true)
        {
            MudarCena.ObjetivoConcluido();
        }

    }
}
