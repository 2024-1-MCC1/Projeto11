using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnFall : MonoBehaviour
{

    public Rigidbody marioRb;

    // Update is called once per frame
    void Update()
    {
        if(marioRb.transform.position.y <= -8)
        {
            MudarCena.MiniGameDonkeyKong();
        }
    }
}
