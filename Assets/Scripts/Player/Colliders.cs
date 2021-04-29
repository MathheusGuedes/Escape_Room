
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliders : MonoBehaviour
{
    public GameObject puzzle1, puzzle2, puzzle3, door, pnlEndDialog;
    public GameManager _gameManager;
    public bool pressEVisible = false;
    public GameObject pressE;
    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            puzzle1.SetActive(false);
            puzzle2.SetActive(false);
            puzzle3.SetActive(false);
        }

        if(puzzle1.activeSelf || puzzle2.activeSelf || puzzle3.activeSelf)
        {
            pressE.SetActive(false);
        }
        else if(pressEVisible)
        {
            pressE.SetActive(true);
        }
        else{
            pressE.SetActive(false);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Puzzle1")
        {
            pressEVisible = true;
            if(Input.GetKey(KeyCode.E))
            {   
                pressEVisible = false;
                puzzle1.SetActive(true);
            }
            
        }
        if(other.gameObject.tag == "Puzzle2" )
        {   
            pressEVisible = true;
            if(Input.GetKey(KeyCode.E))
            {
                puzzle2.SetActive(true);
                pressEVisible = false;
            }
            
        }
        if(other.gameObject.tag == "Puzzle3" )
        {   
            pressEVisible = true;
            if(Input.GetKey(KeyCode.E))
            {
                puzzle3.SetActive(true);
                pressEVisible = false;
            }
            
        }
        if(other.gameObject.tag == "Door" )
        {   
            if(_gameManager.points != 3)
            {
                pressEVisible = true;
                if(Input.GetKey(KeyCode.E))
                {
                    pressEVisible = false;
                    door.SetActive(true);
                }
            }
            else if(_gameManager.points >= 3 && Input.GetKey(KeyCode.E)){
                pnlEndDialog.SetActive(true);
            }
            else if(!pnlEndDialog.GetComponent<DialogManager>().inDialog)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    private void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Puzzle1")
        {   
            pressEVisible = false;
            puzzle1.SetActive(false);
        }
        if(other.gameObject.tag == "Puzzle2")
        {
            pressEVisible = false;
            puzzle2.SetActive(false);
        }
        if(other.gameObject.tag == "Puzzle3")
        {
            pressEVisible = false;
            puzzle3.SetActive(false);
        }
        if(other.gameObject.tag == "Door")
        {   
            pressEVisible = false;
            door.SetActive(false);
        }

    }
}
