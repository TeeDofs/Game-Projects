using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryManager : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
        }

        if(collision.gameObject.tag == "EnemyProjectile")
        {
            Destroy(collision.gameObject);
        }
    }
}
