using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OneWayPlatform : MonoBehaviour
{
    private Collider plataformaCollider;

    void Start()
    {
        plataformaCollider = GetComponent<Collider>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.position.y < transform.position.y)
            {
                Physics.IgnoreCollision(collision.collider, plataformaCollider, true);
            }
            else
            {
                Physics.IgnoreCollision(collision.collider, plataformaCollider, false);
            }
        }
    }
}
