using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Light myLight;
    public int health = 100;
    public int healthBonus = 10;
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        //myLight.color = Color.blue;
        myLight.color = new Color(0.1f, 0.24f, 0.85f);
        AddToHealth();

        //Adds full health
        AddToHealth(100);

        //Adds half health
        AddToHealth(50);

        //Adds tiny health
        AddToHealth(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            AddToHealth(1);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            AddToHealth(50);
            Debug.Log("Big Health");
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            AddToHealth(150);
            Debug.Log("Big Health Up");
        }

        Movement();

        //if (health != 100)
        //    Debug.Log("Not at full health");

    }


    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            RaycastHit hit;

            if (Physics.Raycast(transform.position, Vector3.forward, out hit, 100.0f))
            {
                print("Found a: " + hit.collider.name);
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }

            Debug.DrawRay(transform.position, Vector3.forward, Color.blue);
        }
    }


    void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * speed);
    }

    //This adds to our health
    void AddToHealth()
    {
        health += healthBonus;
    }

    void AddToHealth(int healthModifier)
    {
        health += healthModifier;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Poison"))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (other.gameObject.CompareTag("Health"))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Poison"))
        {
            health -= 1;
        }
        if (other.gameObject.CompareTag("Health"))
        {
            health += 1;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

}
