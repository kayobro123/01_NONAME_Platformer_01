using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed = 10;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 moveAmount = InputAndMoveAmount();

        transform.Translate(moveAmount);
    }

    private Vector2 InputAndMoveAmount()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Jump"));
        Vector2 direction = input.normalized;
        Vector2 velocity = direction * speed;
        Vector2 moveAmount = velocity * Time.deltaTime;
        return moveAmount;
    }

/*  private float GroundLineTrace()
    {
         return 
    }*/
}
