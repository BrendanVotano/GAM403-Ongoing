using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsProjectile : MonoBehaviour
{
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PointBox"))
        {
            GM.score += 100;
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
        
        //Debug.Log("We hit " + collision.collider.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("PointBox"))
        {
            GM.score += 1;
        }
        
        //Debug.Log("We are still hitting " + collision.collider.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        //Destroy(collision.gameObject);
        collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        //Debug.Log("We are no longer hitting " + collision.collider.name);
    }
}
