using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerTxt;      
    [SerializeField] static float remainingTime = 300;
    [SerializeField] bool timerOn = false;

    private void Start()
    {
        timerOn = true;
    }
    private void Update()
    {
        if (timerOn)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;           
            }

            else if (remainingTime < 0)

            {
                MudarCena.TimeOut();
                remainingTime = 0;
                timerOn = false;
            }
        }

        int minutos = Mathf.FloorToInt(remainingTime / 60);
        int segundos = Mathf.FloorToInt(remainingTime % 60);
        timerTxt.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }


    public void pause()
        {
        timerOn = false;
        }

    public void sairParaOMenu()
    {
        remainingTime = 300;
        Time.timeScale = 1;
    }

    public void retomaTempo()
    {
        Time.timeScale = 1;
    }

    public void ReiniciaJogo()
    {
        remainingTime = 300;
    }


}
