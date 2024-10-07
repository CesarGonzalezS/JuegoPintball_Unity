using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject spawn;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = spawn.transform.position;
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("Entro el jugador, se pasara al spawn");
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}