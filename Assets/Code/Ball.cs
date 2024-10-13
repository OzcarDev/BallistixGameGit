using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Ball : MonoBehaviour
{
    private IObjectPool<Ball> ballPool;
    private Rigidbody rb;
    [SerializeField] private float speedMultiplier = 1.5f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    public void SetPool(IObjectPool<Ball> pool
        )
    {
        ballPool = pool;
    }

    private void OnTriggerEnter(Collider other)
    {
        rb.velocity = Vector3.zero;
        ballPool.Release(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity *= speedMultiplier;
    }
}
