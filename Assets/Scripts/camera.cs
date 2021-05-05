using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.Translate(0.1f, 0f, 0f);  
        }  
        if (Input.GetKey(KeyCode.A))  
        {  
            transform.Translate(-0.1f, 0f, 0f);  
        }  
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.Translate(0.0f, 0f, -0.1f);  
        }  
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.Translate(0.0f, 0f, 0.1f);  
        }
        if (Input.GetKey(KeyCode.Q))  
        {  
            transform.Translate(0.0f, -0.1f, 0f);  
        }
        if (Input.GetKey(KeyCode.E))  
        {  
            transform.Translate(0.0f, 0.1f, 0f);  
        }
        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            //this.transform.Rotate(Vector3.up, 10 * Time.deltaTime);  
            this.transform.Rotate(-50 * Time.deltaTime, 0, 0);
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            //this.transform.Rotate(Vector3.up, -10 * Time.deltaTime); 
            this.transform.Rotate(50 * Time.deltaTime, 0, 0); 
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(0, -50 * Time.deltaTime, 0); 
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(0, 50 * Time.deltaTime, 0);  
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
