using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTrampa : MonoBehaviour
{
    public GameObject activarTrampa;
    public Rigidbody rock;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Carro")
        {
            rock.GetComponent<Rigidbody> ().useGravity = true;
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
