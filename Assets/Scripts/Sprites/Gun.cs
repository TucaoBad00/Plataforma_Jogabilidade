using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Bullet balaBase;
    public Transform positionToShoot;
    public float fireRate;
    private Coroutine cooldown;
    public Transform direcao;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            cooldown = StartCoroutine(FireRate());
            shoot();
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            if(cooldown != null) StopAllCoroutines();
        }
    }
    IEnumerator FireRate()
    {
        while(true)
        {
            shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }
    public void shoot()
    {
        var bala = Instantiate(balaBase);
        bala.transform.position = positionToShoot.position;
        balaBase.playerDirection = direcao.localScale.x;
    }
}
