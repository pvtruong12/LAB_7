using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongTam : MonoBehaviour
{
    public float delayDesTroy = 0.5f;
    private Rigidbody2D rb;
    public GameObject prefabvuno;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(5, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("BongBay") || collision.CompareTag("GioiHan"))
        {
            if (collision.CompareTag("BongBay"))
                Instantiate(prefabvuno, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
}
