using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minX, maxX;
    public float minY, maxY;

    public float lifeTime;
    void Start()
    {
        rb.velocity = new Vector2(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY)
            );

        Destroy(gameObject, lifeTime);
    }

}
