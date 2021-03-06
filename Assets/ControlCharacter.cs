 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour
{
    public GameObject characterPrincipal;
    public float velocidad = 20f;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3.185495F, 0F, -11.76979F);
      
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.UpArrow) ) {
            transform.position += Vector3.forward * Time.deltaTime;
        }

       if( Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime;
          
        }
              
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
            transform.eulerAngles += new Vector3(0, velocidad *Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right * Time.deltaTime;
            transform.eulerAngles -= new Vector3(0, velocidad *Time.deltaTime,0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bala, transform.position, transform.rotation);
        }


     




    }
}
