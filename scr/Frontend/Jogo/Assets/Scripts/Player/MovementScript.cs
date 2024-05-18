using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //Variáveis
    public float speed = 1;
    public Rigidbody CityPlayerRb;

    // Update is called once per frame
    void Update()
    {
        //Define as variáveis para quando se aperta as setinhas do teclado ou WASD
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalMove, 0, verticalMove);//define uma variavel de movimentação apenas nos eixos X e Z, juntando as variaveis criadas anteriormente 
        transform.Translate(moveDirection * speed * Time.deltaTime);//Utiliza a variável para que o objeto se mova dentro do jogo ao apertar as teclas

        if (CityPlayerRb.transform.position.y <= -30f)
        {
            MudarCena.MainGameCidade();
        }
    
    }
}
