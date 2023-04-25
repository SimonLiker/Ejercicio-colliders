using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trianguloScript : MonoBehaviour
{

    float speed = 0.2f;
    float rotationSpeed = 4f;

    public GameObject triangle2;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W))
        {
                transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, speed * -1, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            triangle2.transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            triangle2.transform.Translate(0, speed * -1, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            triangle2.transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            triangle2.transform.Translate(-speed, 0, 0);
        }
    }
}
