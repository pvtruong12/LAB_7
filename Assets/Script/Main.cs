using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject getBongBay;
    public GameObject getPrefabVienDan;
    public int maxNumber;
    public float delayFor = 2f;
    public float MoveSpeed = 2f;
    private Animator animator;
    private bool isCreadNew = false;
    public bool isAttack = false;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void CreateBong()
    {
        float x = Random.Range(-9.3f, 9.5f);
        Vector3 localPostions = new Vector3(x, -5.7f, 0);
        Instantiate(getBongBay, localPostions, Quaternion.identity);
    }
    public void MobeChar()
    {
        float y = Input.GetAxisRaw("Vertical");
        Vector2 vt = new Vector2(0, y);
        rb.velocity = vt.normalized * MoveSpeed;
    }
    public void Attack()
    {
        if (!isAttack)
        {
            isAttack = true;
            Instantiate(getPrefabVienDan, transform.position, Quaternion.identity);
            isAttack = false;
        }
    }
    void FixedUpdate()
    {
        MobeChar();
        if(Input.GetKeyDown(KeyCode.V))
        {
            Attack();
            animator.SetTrigger("isAttack");
        }
        if (!isCreadNew)
        {
            isCreadNew = true; StartCoroutine(createdBong());
        }
    }
    public IEnumerator createdBong()
    {
        yield return new WaitForSeconds(delayFor);
        CreateBong();
        isCreadNew = false;
    }
}
