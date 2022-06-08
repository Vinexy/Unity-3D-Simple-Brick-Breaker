using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class box : MonoBehaviour
{

    
    [SerializeField] GameObject explosion;
    
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
            
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
      


    }
}
