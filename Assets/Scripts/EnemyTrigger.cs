using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public GameObject Enemy;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Instantiate(Enemy,spawnPoint.position,Quaternion.identity);
        }
    }
}
