using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
   
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
