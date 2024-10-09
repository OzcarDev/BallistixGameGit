using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement(GetInput());
    }

    private float GetInput()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        return horizontalInput;
    }
}
