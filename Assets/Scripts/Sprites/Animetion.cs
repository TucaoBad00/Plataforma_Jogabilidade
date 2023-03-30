using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animetion : MonoBehaviour
{
    public Animator ani;
    public string Run = "Run";
    public string Idle = "Idle";
    private void OnValidate()
    {
        if (ani == null) ani = GetComponent<Animator>();

    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            ani.SetTrigger(Run);
        }
    }
}
