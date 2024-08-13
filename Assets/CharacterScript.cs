using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public Rigidbody2D charBody;
    private bool charAlive = true;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Jump(touch.position);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Jump(mousePos);
        }
    }
    void Jump(Vector2 inputPos)
    {
        charBody.velocity = Vector2.up * jumpPower;
    }
}
