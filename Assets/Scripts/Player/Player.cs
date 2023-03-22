using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D corpo;
    public Vector2 velocidade;
    public float speed;
    public float jumpForce;
    public float run;
    private float currentspeed;
    private void Update()
    {

        if(Input.GetKey(KeyCode.LeftShift))
        {
            currentspeed = run;
        }
        else
        {
            currentspeed = speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //corpo.MovePosition(corpo.position - velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(-currentspeed, corpo.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //corpo.MovePosition(corpo.position + velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(+currentspeed, corpo.velocity.y);
        }
        
        jump();
    }
    private void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            corpo.velocity = Vector2.up * jumpForce;
        }
    }
}
