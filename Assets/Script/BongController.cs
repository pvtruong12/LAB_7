using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BongController : MonoBehaviour
{
    public Sprite[] Sprites;
    private SpriteRenderer sp;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = Random.Range(-0.8f, -1f);
        sp = GetComponent<SpriteRenderer>();
        int random = Random.Range(0, Sprites.Length -1);
        sp.sprite = Sprites[random];
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("GioiHan") || collision.CompareTag("viendan"))
        {
            Destroy(gameObject);
        }
    }
}
