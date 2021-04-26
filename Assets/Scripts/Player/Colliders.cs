using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    public GameObject puzzle1, puzzle2, puzzle3;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            puzzle1.SetActive(false);
            puzzle2.SetActive(false);
            puzzle3.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Puzzle1" )
        {
            if(Input.GetKeyDown("e"))
            puzzle1.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Puzzle1")
        {
            puzzle1.SetActive(false);
        }
    }
}
