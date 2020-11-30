using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrcutable : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject destroyedversion;
    void OnMouseDown()
    {
        Instantiate(destroyedversion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
