using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Transform groundCheckpoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
   private bool isGrounded;
    Animator anim;

    void Start()

    {
       // Start is called before the first frame update
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //constant forward movement
        rb.linearVelocity = new UnityEngine.Vector2(moveSpeed, rb.linearVelocity.y);

        //check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckpoint.position, checkRadius, groundLayer);

        //jumping logic
        if (isGrounded && Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Jump();
        }

        anim.SetBool("IsOnGround", isGrounded);
    
    
    }



    private void Jump()
    {
        //set upward velocity for jumping
        rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        //draw a circle to visualise the ground check point in the editor
        if (groundCheckpoint == null) return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckpoint.position, checkRadius);
    }




   


}


