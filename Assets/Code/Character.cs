using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float xLimit;
    [SerializeField] public bool isXMovement;
    public void Movement(float x)
    {
        
      
        
        if(isXMovement) {
            transform.Translate(Vector3.right * speed * x * Time.deltaTime);
            float xPos = Mathf.Clamp(transform.localPosition.x, -xLimit, xLimit);
            transform.localPosition = new Vector3(xPos,transform.localPosition.y, transform.localPosition.z);
        }
        else
        {
            transform.Translate(Vector3.forward * speed * x * Time.deltaTime);
            float zPos = Mathf.Clamp(transform.localPosition.z, -xLimit, xLimit);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, zPos);
        }
    }
}
