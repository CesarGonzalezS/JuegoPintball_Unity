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
            // Aseg�rate de que el objeto spawn est� asignado
            if (spawn != null)
            {
                // Mueve al jugador a la posici�n de spawn
                other.transform.position = spawn.transform.position;

                // Aseg�rate de que el jugador tiene un Rigidbody
                Rigidbody rb = other.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.velocity = Vector3.zero; // Detiene el movimiento del jugador
                }

                Debug.Log("Entr� el jugador, se pasar� al spawn");
            }
            else
            {
                Debug.LogWarning("El objeto spawn no est� asignado en el inspector.");
            }
        }
    }

    void Start()
    {
        // Puedes inicializar cualquier cosa aqu� si es necesario
    }

    void Update()
    {
        // Puedes manejar la l�gica de actualizaci�n aqu� si es necesario
    }
}
