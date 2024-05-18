using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class interactor : MonoBehaviour
{
    //variáveis
    public LayerMask interactableLayerMask = 8;
    public Image interactImage;
    interactable interactable;
    public Sprite defaultIcon;
    public Vector2 defaultIconSize;
    public Vector2 defaultInteractIconSize;
    public Sprite defaultInteractionIcon;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 3, interactableLayerMask))
        {
            if (hit.collider.GetComponent<interactable>() != false)
            {
                if (interactable == null || interactable.ID != hit.collider.GetComponent<interactable>().ID)
                {
                    interactable = hit.collider.GetComponent<interactable>();
                }

                if (interactable.interactIcon != null)
                {
                    interactImage.sprite = interactable.interactIcon;
                    if (interactable.iconSize == Vector2.zero)
                    {
                        interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                    }
                    else
                    {
                        interactImage.rectTransform.sizeDelta = interactable.iconSize;
                    }
                }

                else
                {
                    interactImage.sprite = defaultInteractionIcon;
                    interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.onInteract.Invoke();
                }
            }
        }
        else
        {
            if (interactImage.sprite != defaultIcon)
            {
                interactImage.sprite = defaultIcon;
                interactImage.rectTransform.sizeDelta = defaultIconSize;
            }
        }
    }
}
