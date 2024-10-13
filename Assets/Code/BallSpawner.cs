using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    
    [SerializeField] private float ballsSpeed;
    [SerializeField] private float spawnFrecuency;
    [SerializeField] private float timeToStartSpawn;
   

    private void Start()
    {
        InvokeRepeating("Spawnballs", timeToStartSpawn, spawnFrecuency);
    }
    private void Spawnballs()
    {
        Rigidbody actualBall = BallManager.Instance.BallsPool.Get().gameObject.GetComponent<Rigidbody>();
        actualBall.transform.position = gameObject.transform.position;
        actualBall.transform.rotation = gameObject.transform.rotation;
        actualBall.AddForce(transform.forward * ballsSpeed, ForceMode.Impulse);
    }

  
}
