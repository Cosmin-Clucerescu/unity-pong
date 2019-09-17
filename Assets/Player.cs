using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayer1 = false;
    public float speed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var input = "Vertical";
        if (!isPlayer1)
            input = "Vertical2";
        GetComponent<Rigidbody>().velocity = new Vector3(0f, Input.GetAxis(input) * speed*100 * Time.deltaTime, 0f);
    }
}
