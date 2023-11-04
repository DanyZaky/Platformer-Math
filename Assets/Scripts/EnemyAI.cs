using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Kecepatan pergerakan musuh
    private Rigidbody2D rb;
    private bool movingRight = true; // Musuh bergerak ke kanan saat dimulai

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Bergerak ke depan
        Vector2 movement = movingRight ? Vector2.right : Vector2.left;
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }

    // Menggunakan OnTriggerEnter2D untuk deteksi trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Jika tabrakan dengan objek yang memiliki tag "SidePlatform"
        if (other.CompareTag("SidePlatform"))
        {
            // Balik arah musuh
            Flip();
        }
    }

    void Flip()
    {
        // Balik arah musuh
        movingRight = !movingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
}
