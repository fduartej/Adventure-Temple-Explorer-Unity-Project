﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed=15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement(){
        //Cambiar de animacion
        if (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow)){
            gameObject.GetComponent<Animator>().SetBool("running", false);
        }else{
            //Cambiar la Mirada
            if (Input.GetKey(KeyCode.RightArrow)) gameObject.GetComponent<SpriteRenderer>().flipX = false;
            if (Input.GetKey(KeyCode.LeftArrow))  gameObject.GetComponent<SpriteRenderer>().flipX = true;

            gameObject.GetComponent<Animator>().SetBool("running", true);
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            transform.position += move * Time.deltaTime * playerSpeed;
        }
    }
}