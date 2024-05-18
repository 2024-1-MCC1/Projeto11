using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class infiniteMap : MonoBehaviour
{
    public GameObject pipeSection;
    public TMP_Text title;
    public TextMeshProUGUI timerTxt;
    public TMP_Text pontuacao;
    public TMP_Text lifes;
    public Rigidbody playerRb;
    public Rigidbody pipesRb;

    int pontos;
    int vidas = 3;
    int contadorMortes = 0;
    

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timerTxt.enabled = false;
    }


    public void Update()
    {
        if (pontos == 10)
            MudarCena.ObjetivoConcluido();

        else if (contadorMortes == 3)
            MudarCena.ObjetivoNaoConcluido();
    }


    private void OnTriggerEnter(Collider other)
    {
        float pos = Random.Range(3.0f, 0.1f);

        if (other.gameObject.CompareTag("invisible_wall"))
        {
            Instantiate(pipeSection, new Vector3(2f, pos, -8f), Quaternion.identity);
            title.enabled = false;
            timerTxt.enabled = true;
        }


        if (other.gameObject.CompareTag("points"))
        {
            pontos++;
            pontuacao.SetText(pontos.ToString());
        }
    }


    private void Reset()
    {
        DestroyAllObjectsWithTag("pipes");
        DestroyAllObjectsWithTag("points");
        pontos = 0;
        pontuacao.SetText(pontos.ToString());
        playerRb.transform.position = new Vector3(-5, 1, -0.5f);
        pipesRb.transform.position = new Vector3(0.25f, 1, -8.04f);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pipes") || (collision.gameObject.CompareTag("ground")))
        {
            vidas--;
            lifes.SetText(vidas.ToString());
            contadorMortes++;
            Reset();
        }
    }



    //FEITA PELO CHATGPT: serve para destruir objetos com uma tag específica
    void DestroyAllObjectsWithTag(string tag)
    {
        // Find all game objects with the specified tag
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);

        // Loop through them and destroy each one
        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }
}

