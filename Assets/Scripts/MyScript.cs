using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public float playerSpeed;
    public float speedBurst = 2;
    public int ammo = 400;
    //public int health = 100;
    public float playerAccuracyForThisMatch = 15.5f;
    public string player = "Brendan";
    public Vector3 starting;

    void Start()
    {
        if(ammo <= 10)
        {
            Debug.Log("Ammo is low");
        }
        Debug.Log("My Ammo Is: " + ammo);
    }
    
    // Update is called once per frame
    void Update()
    {
        playerSpeed = playerSpeed + speedBurst;

        //Moves out player in the forward direction every frame by player speed
        transform.Translate(Vector3.forward * playerSpeed);

        //makes the player jump by 2 units
    }
}
