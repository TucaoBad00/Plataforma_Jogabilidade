using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    #region Variaveis
    public Rigidbody2D corpo;
    public SOPlayerParameters PlayerParameters;
    private float currentspeed;
    public Animator ani;
    public ParticleSystem ParticleSystemJump;
    #endregion
    private void Update()
    {

        if(Input.GetKey(KeyCode.LeftShift))
        {
            currentspeed = PlayerParameters.run;
        }
        else
        {
            currentspeed = PlayerParameters.speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //corpo.MovePosition(corpo.position - velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(-currentspeed, corpo.velocity.y);
            ani.SetBool("Run",true);
            corpo.transform.localScale = new Vector3(-1f,1f,1);
            
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            //corpo.MovePosition(corpo.position + velocidade * Time.deltaTime);
            corpo.velocity = new Vector2(+currentspeed, corpo.velocity.y);
            ani.SetBool("Run",true);
                        corpo.transform.localScale = new Vector3(1f,1f,1);
        }
        else
        {
            ani.SetBool("Run",false);

        }
        jump();

    }
    private void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            corpo.velocity = Vector2.up * PlayerParameters.jumpForce;
            if(ParticleSystemJump != null) { ParticleSystemJump.Play(); }
        }
    }
  
}
