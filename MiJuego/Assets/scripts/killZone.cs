using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject spawn;

    private void OnCollisionEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Asegúrate de que el objeto spawn está asignado
            if (spawn != null)
            {
                // Mueve al jugador a la posición de spawn
                other.transform.position = spawn.transform.position;

                // Asegúrate de que el jugador tiene un Rigidbody
                Rigidbody rb = other.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = Vector3.zero; // Detiene el movimiento del jugador
                }

                Debug.Log("Entró el jugador, se pasará al spawn");
            }
            else
            {
                Debug.LogWarning("El objeto spawn no está asignado en el inspector.");
            }
        }
    }

    void Start()
    {
        // Puedes inicializar cualquier cosa aquí si es necesario
    }

    void Update()
    {
        // Puedes manejar la lógica de actualización aquí si es necesario
    }
}
