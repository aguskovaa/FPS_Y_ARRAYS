using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");

        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        
        if (collision.gameObject.GetComponent<AlimentoScript>() != null)
        {
            Destroy(collision.gameObject);
        }
        
        
        
        
    }
}
