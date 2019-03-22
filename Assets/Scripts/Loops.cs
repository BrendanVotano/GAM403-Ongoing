using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public GameObject brick;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(brick,(new Vector3(1,1,0)*i), brick.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
