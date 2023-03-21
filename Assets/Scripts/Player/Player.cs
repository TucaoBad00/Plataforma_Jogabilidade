using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D corpo;
    public Vector2 velocidade;
    public float speed;
    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //corpo.MovePosition(corpo.position - velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(-speed, corpo.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //corpo.MovePosition(corpo.position + velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(+speed, corpo.velocity.y);
        }
    }
}
