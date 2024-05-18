using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenFruitNinja : MonoBehaviour
{
public void ChangeSceneFruitNinja(string sceneFruitNinja)
    {
        SceneManager.LoadScene(sceneFruitNinja);
    }
}
