using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifleDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Collided with enemy");
            Destroy(gameObject);
        }
    }
}
