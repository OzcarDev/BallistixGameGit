using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private float ballsSpeed;
    [SerializeField] private float spawnFrecuency;

    private void OnEnable()
    {
        InvokeRepeating("Spawnballs", 1, spawnFrecuency);
    }
    private void Spawnballs()
    {
        Rigidbody actualBall = Instantiate(ball,transform.position,transform.rotation).GetComponent<Rigidbody>();
        actualBall.velocity = new Vector3(0,0,ballsSpeed);
    }
}
