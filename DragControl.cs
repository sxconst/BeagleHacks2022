using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour
{
    Vector2 difference = Vector2.zero;
    public static bool beagleIsHeld= false;

    private void OnMouseDown()
    {
        if (ThePauseMenu.GameIsPaused == false && Menu.gameIsOver == false)
        {
            difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
            beagleIsHeld = true;
        }
    }

    private void OnMouseDrag()
    {
        if (ThePauseMenu.GameIsPaused == false && Menu.gameIsOver == false)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
            beagleIsHeld = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
