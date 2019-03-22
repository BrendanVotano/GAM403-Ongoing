using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("DoorOpen");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("DoorClose");
    }
}
