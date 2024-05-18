using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPrimeiraPessoa : MonoBehaviour
{

    //Variáveis
    public Transform player;
    public float mouseSenseX = 2f;
    public float mouseSenseY = 2f;
    float rotation = 0f;


    private void Start()
    {
        //Deixa o cursor invisível
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if(Time.timeScale == 1)
        {
             //Definindo que ao mexer o mouse pro lado, a camera gira junto
             float x = Input.GetAxis("Mouse X") * mouseSenseX;
             float y = Input.GetAxis("Mouse Y") * mouseSenseY;

            rotation -= y;//Isso é feito para que o método Mathf.Clamp funcione propriamente
            rotation = Mathf.Clamp(rotation, -90f, 90f);//Serve para manter a rotação da camera no eixo Y, presa entre as coordenadas de Y -90 e 90 
            transform.localEulerAngles = Vector3.right * rotation;//gira a camera no eixo Y

            player.Rotate(Vector3.up * x);//gira a camera no eixo X
        }
        



    }
}
