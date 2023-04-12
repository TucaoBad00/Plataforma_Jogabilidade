using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public float startLife;
    public float _currentLife;
    public bool isDead = false;

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
    private void Kill()
    {
        isDead = true;
        Destroy(gameObject);
    }
    public void Update()
    {

    }
}
