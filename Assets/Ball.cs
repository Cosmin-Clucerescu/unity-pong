using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    void Start()
    {
        float dx = Random.Range(0, 2) > 0 ? -1: 1 ;
        float dy = Random.Range(0, 2) > 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * dx, speed * dy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
