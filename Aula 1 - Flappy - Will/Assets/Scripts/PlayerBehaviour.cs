using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private GameManager gameManager;
    
    private Rigidbody2D rigidbody;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody.linearVelocity = Vector2.up * jumpForce;
        }
        
        transform.rotation = Quaternion.Euler(0f,0f,rigidbody.linearVelocity.y*rotationSpeed);
        
    }
    
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
        //if (collision.GameObject == "Colisor");
        //{
        //    Time.timeScale = 0f;
        //    gameManager.gameOver();
        //}
    //}
}
