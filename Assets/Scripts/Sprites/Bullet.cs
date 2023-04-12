using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public Vector3 direction;
    public int lifeTime;
    public float playerDirection = 1;
    void Start()
    {
        
    }

    void Awake()
    {
        Destroy(gameObject, lifeTime);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * playerDirection * Time.deltaTime);
    }
}
