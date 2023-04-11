using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaEtViens : MonoBehaviour
{
    private float min = 2f;
    private float max = 3f;

    
    void Start()
    {
        min=transform.position.x;
        max=transform.position.x+20;
    }

    
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 20, max - min) + min, transform.position.y, transform.position.z);
    }
}
