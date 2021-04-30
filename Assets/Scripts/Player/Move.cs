using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Animator anim ;
    public float velRotate;

    [Header("CAMERA / ROTACAO")]
    public float sensibilidade = 2.0f;
    private float mouseX = 0.0f, mouseY = 0.0f;
    public GameObject CameraTarget;
    public PanelManager _panelManager;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        _panelManager = GameObject.Find("PanelManager").GetComponent<PanelManager>();
        
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
        if(_panelManager.cursorLock)
        {
            Rotacao();
        }
        
    }

    void Rotacao()
    {   
        mouseX += Input.GetAxis("Mouse X") * sensibilidade; 
        mouseY += Input.GetAxis("Mouse Y") * -sensibilidade;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
        CameraTarget.transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
