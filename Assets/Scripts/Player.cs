using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public or private reference
    //data type (int, float, bool, string)
    //every variable has a name
    //optional value assigned
    [SerializeField]
    private float _speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        //take the current position = new position (0, 0, 0)
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
    
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //new Vector3(1, 0, 0) * 0 * 3.5f * real time
        //transform.Translate(Vector3.right * horizontalInput * _speed * Time.deltaTime );
        //transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * _speed * Time.deltaTime);
        transform.Translate(direction * _speed * Time.deltaTime);
        //for optimization

        //if player position on the y is greater than 0
        //y position = 0 
        //else if position on the y is less than -3.8f
        //y pos = -3.8f

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if(transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }

        if (transform.position.x >= 11.3f)
        {
            //transform.position = new Vector3(9, transform.position.y, 0);
            transform.position = new Vector3(-11.3f, transform.position.y, 0);
        }
        else if(transform.position.x <= -11.3f) 
        {   
            //transform.position = new Vector3(-9f, transform.position.y, 0);
            transform.position = new Vector3(11.3f, transform.position.y, 0);
        }

        //if player on the x > 11 
        //x pos = -11
        //else if player on the x is less than -11
        //x pos = 11
    }
}
