using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Animals
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wolf"))
        {
            Jump(600);
        }
    }
}
