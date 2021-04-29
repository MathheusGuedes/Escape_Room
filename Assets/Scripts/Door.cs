using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameManager _gameManager;
    [SerializeField] private GameObject pnlDoor;
    void Start()
    {
        anim = GetComponent<Animator>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        if(_gameManager.points >= 3)
        {
            anim.SetBool("Open", true);
        }
    }
}
