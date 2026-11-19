using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaVersioA : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
