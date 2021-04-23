using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public bool mouseOver;
    public bool clicked;
    public bool clickable;

    Collider2D collider;
    int enableTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        mouseOver = false;
        clicked = false;

        collider = GetComponent<Collider2D>();
        collider.enabled = false;
        
    }

    private void Update()
    {
        if (collider.enabled == false)
        {
            enableTimer++;

            if (enableTimer > 10)
            {
                collider.enabled = true;
            }
        }

        if (mouseOver)
        {
            if (Input.GetMouseButtonDown(0) && clickable)
            {
                clicked = true;
                Debug.Log("Clicked");
            }
        }
    }

    void OnMouseEnter()
    {
        mouseOver = true;
        Debug.Log("Over");
    }

    void OnMouseExit()
    {
        mouseOver = false;
    }
}
