using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geniss_Script : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start() //ONLY RUNS ONCE
    {
        gameObject.name = "Genisssss";

    }

    //movement speed in units per second
    private float movementSpeed = 5f;

    // Update is called once per frame
    void Update() //CONTANTLY - EVERYT LINE OF CODE, EVERY FRAME
    {

        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        //output to log the position change
        Debug.Log(transform.position);

    }
   
}




    