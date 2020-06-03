using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    bool allowedToMove;
    Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); //gets touch information of first finger pressed
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if(col == touchedCollider)
                {
                    allowedToMove = true;
                }
            }

            if(touch.phase == TouchPhase.Moved)
            {
                if (allowedToMove)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }

            if(touch.phase == TouchPhase.Ended)
            {
                allowedToMove = false;
            }
            
        }
    }
}
