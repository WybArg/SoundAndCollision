using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody myRb;
    public AudioSource mySound;
    
    void Start()
    {
        myRb.useGravity = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad1) && this.gameObject.layer == 10)
        {
            OnCollision();
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) && this.gameObject.layer == 11)
        {
            OnCollision();
        }
        else if(Input.GetKeyDown(KeyCode.Keypad3) && this.gameObject.layer == 12)
        {
            OnCollision();
        }
    }


    public void OnCollision()
    {
        myRb.useGravity = true;
        mySound.Play();
    }







}
