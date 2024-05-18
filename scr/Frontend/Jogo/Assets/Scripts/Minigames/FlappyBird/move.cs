using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    public float spd = 2;
    void Update()
    {
        transform.position += new Vector3(spd * (-1), 0, 0) * Time.deltaTime;
    }

    //destroi os canos que já passaram pelo player
    private void OnTriggerEnter(Collider other)
    {


        {
            if (other.gameObject.CompareTag("destroy"))
                Destroy(gameObject);
        }
    }
}
