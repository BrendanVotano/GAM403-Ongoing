using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public GameObject[] weapons;

    // Start is called before the first frame update
    void Start()
    {
        ChangeWeapons(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeWeapons(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeWeapons(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeWeapons(2);
        if (Input.GetKeyDown(KeyCode.Alpha4))
            ChangeWeapons(3);
    }

    void ChangeWeapons(int weaponNumber)
    {
        for(int i = 0; i < weapons.Length; i++)
        {
            if(i != weaponNumber)
                weapons[i].SetActive(false);
            else
                weapons[i].SetActive(true);
        }
    }
}
