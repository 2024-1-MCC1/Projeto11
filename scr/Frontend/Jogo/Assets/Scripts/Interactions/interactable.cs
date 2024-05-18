using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    public int ID;
    public Sprite interactIcon;
    public Vector2 iconSize;


    private void Start()
    {
        ID = Random.Range(0, 999999);
    }
}
