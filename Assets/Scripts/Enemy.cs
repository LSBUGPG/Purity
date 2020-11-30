using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Spawnpoint;
    public GameObject Prefab;
    void OnTriggerEnter(Collider collider)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        print("Hello");
    }

   
}
