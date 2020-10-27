﻿using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed;
    public float gravity;
    public float jumpForce;
    public CharacterController con;

    private float y;
    private float jumpAc;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(x * speed * Time.deltaTime, y);

        if(Input.GetKey(KeyCode.Space))
        { 
            jumpAc += 1;
            jumpAc = Mathf.Clamp(jumpAc, 0, jumpForce);
            y = jumpAc * Time.deltaTime;

        }
        else
        {
            y -= gravity;
        }

        con.Move(movement);
    }
}
