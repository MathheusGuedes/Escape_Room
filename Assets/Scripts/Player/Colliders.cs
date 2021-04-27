
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
            
            if(Input.GetKey(KeyCode.E))
            puzzle1.SetActive(true);
        }
        if(other.gameObject.tag == "Puzzle2" )
        {
            if(Input.GetKey(KeyCode.E))
            puzzle2.SetActive(true);
        }
        if(other.gameObject.tag == "Puzzle3" )
        {
            if(Input.GetKey(KeyCode.E))
            puzzle3.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Puzzle1")
        {
            puzzle1.SetActive(false);
        }
        if(other.gameObject.tag == "Puzzle2")
        {
            puzzle2.SetActive(false);
        }
        if(other.gameObject.tag == "Puzzle3")
        {
            puzzle3.SetActive(false);
        }

    }
}
