using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public float startLife;
    public float _currentLife;
    public bool isDead = false;
    public Animator animations;

    private void Awake()
    {
        _currentLife = startLife;

    }
    public void Damage(float damage)
    {
        if(isDead) return;
        _currentLife -= damage;
        Debug.Log(damage);
        if(_currentLife <= 0)
        {
            Kill();
        }
    }
    private void Init()
    {
        _currentLife = startLife;
        isDead = false;
    }
    public void Kill()
    {
        isDead = true;
        if(animations != null)
        {
            animations.SetTrigger("Die");
        }

        Destroy(gameObject,0.5f);
    }
    public void Update()
    {

    }
}
