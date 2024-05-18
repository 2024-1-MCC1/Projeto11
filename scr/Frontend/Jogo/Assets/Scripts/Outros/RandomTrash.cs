using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTrash : MonoBehaviour
{
    //Um array para cada lixo aparecendo ao mesmo tempo
    public GameObject[] lixos;//5
    public GameObject[] lixos1;//5
    public GameObject[] lixos2;//4
    public GameObject[] lixos3;//4
    public GameObject[] lixos4;//4
    public GameObject[] lixos5;//4
    public GameObject[] lixos6;//4
    public GameObject[] lixos7;//4
    public GameObject[] lixos8;//4
    public GameObject[] lixos9;//4
    public GameObject[] lixos10;//4
    public GameObject[] lixos11;//4
    int rdm;
    int rdm1;
    int rdm2;
    int rdm3;
    int rdm4;
    int rdm5;
    int rdm6;
    int rdm7;
    int rdm8;
    int rdm9;
    int rdm10;
    int rdm11;
  

    public void Start()
    {
        rdm = Random.Range(0, 5);//randomiza um numero entre 0 e 4
        rdm1 = Random.Range(0, 5);
        rdm2 = Random.Range(0, 4);//randomiza um numero entre 0 e 3
        rdm3 = Random.Range(0, 4);
        rdm4 = Random.Range(0, 4);
        rdm5 = Random.Range(0, 4);
        rdm6 = Random.Range(0, 4);
        rdm7 = Random.Range(0, 4);
        rdm8 = Random.Range(0, 4);
        rdm9 = Random.Range(0, 4);
        rdm10 = Random.Range(0, 4);
        rdm11 = Random.Range(0, 4);

        lixos[rdm].SetActive(true);
        lixos1[rdm1].SetActive(true);
        lixos2[rdm2].SetActive(true);
        lixos3[rdm3].SetActive(true);
        lixos4[rdm4].SetActive(true);
        lixos5[rdm5].SetActive(true);
        lixos6[rdm6].SetActive(true);
        lixos7[rdm7].SetActive(true);
        lixos8[rdm8].SetActive(true);
        lixos9[rdm9].SetActive(true);
        lixos10[rdm10].SetActive(true);
        lixos11[rdm11].SetActive(true);

       
    }

}
