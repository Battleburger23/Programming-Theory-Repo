using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Animals
{
    

    public override IEnumerator MoveItEveryFewSeconds()
    {
        
        while (true)
        {
            yield return new WaitForSeconds(1);
            Move();
            Jump(250);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Deer") || collision.gameObject.CompareTag("Wolf"))
        {
            Destroy(collision.gameObject);
        }
    }

}
