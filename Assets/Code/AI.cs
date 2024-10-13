using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Character
{
    private Ball closestBall;
   

    // Update is called once per frame
    void Update()
    {
        CheckBalls();
        Movement(GetAxis());
    }

    private void CheckBalls()
    {
        closestBall = null;

        if (BallManager.Instance.ActiveBalls.Count > 0)
        {

            foreach (Ball ball in BallManager.Instance.ActiveBalls)
            {
                if (closestBall == null) closestBall = ball;

                if (Vector3.Distance(ball.transform.position, transform.position) < Vector3.Distance(closestBall.transform.position, transform.position))
                {
                    
                    closestBall = ball;
                }
            }

        }
    }

    private float GetAxis()
    {
        if (closestBall == null)
        {
            return 0;
        } else
        if (isXMovement)
        {
            float xBallPos = closestBall.transform.position.x;
            if (transform.position.x < xBallPos)
            {
                return 1;
            }
            else if (transform.position.x > xBallPos)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        else
        {
            float zBallPos = closestBall.transform.position.z;
            if (transform.position.z < zBallPos)
            {
                return 1;
            }
            else if (transform.position.z > zBallPos)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
