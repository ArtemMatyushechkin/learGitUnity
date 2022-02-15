using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveControl : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float moveSpeed, jumpForce;
    private bool moveLeft, moveRight;
    
    
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        jumpForce = 500f;
        moveLeft = false;
        moveRight = false;
        
    }
    public void MoveLeft()
    {
        moveLeft = true;
    }
    public void MoveRight()
    {
        moveRight = true;
        //;glrekgregkergl;krgl;ergkre;gl
    }
    public void Jump()
    {
        if(rb.velocity.y ==0){
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    public void StopMoving(){
        moveRight = false;
        moveLeft = false;
        rb.velocity = Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if(moveLeft){
            rb.velocity = new Vector2(-moveSpeed,0f);
        }
        if(moveRight){
            rb.velocity = new Vector2(moveSpeed,0f);
        }
    }
}
