using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player; // Referência ao transform do jogador
    public Transform objetoRandomizador; // Referência ao objeto que randomiza sua posição
    public Transform marcadorDoObjeto; // Transform do marcador do objeto no mini mapa


    void LateUpdate()
    {
        // Verifica se o jogador existe
        if (player != null)
        {
            // Atualiza a posição do mini mapa para seguir o jogador
            transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);

            // Atualiza a posição do marcador do objeto randomizador no mini mapa
            marcadorDoObjeto.position = new Vector3(objetoRandomizador.position.x, marcadorDoObjeto.position.y, objetoRandomizador.position.z);
        }
    }
}
