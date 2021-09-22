using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTablero : MonoBehaviour
{
    float velocidad = 20f;
    float limite = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float vel = velocidad * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            if (transform.rotation.x < limite)
                transform.Rotate(vel, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.x > -limite)
                transform.Rotate(-vel, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.z < limite)
                transform.Rotate(0, 0, vel);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.z > -limite)
                transform.Rotate(0, 0, -vel);
        }
    }
}
