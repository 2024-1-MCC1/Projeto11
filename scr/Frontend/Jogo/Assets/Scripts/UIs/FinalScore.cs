//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FinalScore : MonoBehaviour
{

    public TextMeshProUGUI finalScore;

    // Update is called once per frame
    void Update()
    {
        finalScore.SetText(MudarCena.lixoColetado.ToString());
    }
}
