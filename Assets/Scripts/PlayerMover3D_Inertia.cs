using UnityEngine;

public class PlayerMover3D_Inertia : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 velocidadActual;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 velocidadDeseada = new Vector3(x, 0, z) * velocidad;

        velocidadActual = Vector3.Lerp(velocidadActual, velocidadDeseada, 0.1f);

        transform.Translate(velocidadActual * Time.deltaTime);
    }
}
