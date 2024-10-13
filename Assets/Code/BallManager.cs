using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BallManager : MonoBehaviour
{
    public List<Ball> ActiveBalls;
    public static BallManager Instance;
    public IObjectPool<Ball> BallsPool;
    [SerializeField] private Ball ballPrefab;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        BallsPool = new ObjectPool<Ball>(
            CreateBall,
            OnGet,
            OnRelease
            );
    }

    private void OnRelease(Ball obj)
    {
        obj.gameObject.SetActive(false);
        ActiveBalls.Remove(obj);

    }

    private void OnGet(Ball obj)
    {
        obj.gameObject.SetActive(true);
        ActiveBalls.Add(obj);
    }

    private Ball CreateBall()
    {
        Ball ball = Instantiate(ballPrefab);
        ball.SetPool(BallsPool);
        return ball;

    }
}
