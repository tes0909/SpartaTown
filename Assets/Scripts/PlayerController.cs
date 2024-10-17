using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); ;
        float y = Input.GetAxisRaw("Vertical"); ;

        transform.position += (new Vector3(x, y)).normalized * Time.deltaTime * speed;

        Vector3 mousePos = Input.mousePosition;

        if(mousePos.x <= Screen.width / 2 )
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
