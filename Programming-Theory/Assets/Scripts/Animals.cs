using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    protected Rigidbody rb;

    private int JumpForce;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(MoveItEveryFewSeconds());
        
    }

    protected virtual void Jump(int jumpForce)
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    protected void Move(int moveSpeed = 20)
    {
        Vector3 randomDir = new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1f));
        rb.AddForce(randomDir * moveSpeed);
    }

    public virtual IEnumerator MoveItEveryFewSeconds()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            Move();
        }
        
    }

}
