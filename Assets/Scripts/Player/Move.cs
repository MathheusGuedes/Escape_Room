using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator anim ;
    public float velRotate;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * Time.deltaTime * velRotate,0));

        if (Input.GetKeyDown("space")){
            print("pulo");
            anim.SetBool("Jump", true);
        }
        else{
            anim.SetBool("Jump", false);
        }
    }
}
