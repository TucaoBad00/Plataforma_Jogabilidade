using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public float damage;
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var health = collision.gameObject.GetComponent<HealthBase>();
        if(health != null)
        {
            health.Damage(damage);
        }
    }
    public void Start()
    {
       var posicaoDoPlayer = player.GetComponent<Transform>();
       Vector2 horizontal = posicaoDoPlayer.position;
    }
}
