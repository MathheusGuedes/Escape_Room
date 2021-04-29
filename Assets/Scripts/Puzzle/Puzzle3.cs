using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;

public class Puzzle3 : MonoBehaviour, IPointerClickHandler
{   
    
    [SerializeField] private Quaternion quat;
    [SerializeField] private float eulerAngZ;
    [SerializeField] public bool addPoints = true;
    [SerializeField] private GameManager _gameManager;


    void Awake()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        addPoints = true;
        quat = transform.rotation;
    }

    public void OnPointerClick(PointerEventData eventData)
    {  
        quat = transform.rotation;
        quat *= Quaternion.Euler(0, 0, 90);
    }

    void Update()
    {
        transform.rotation = quat;
        CheckAngles();
    }

    void CheckAngles()
    {
        if(transform.localEulerAngles.z == 0)
        { 
            if(addPoints)
            {
                _gameManager.pointsPuzzle3++;
            } 
            if(_gameManager.pointsPuzzle3 >= 9 && _gameManager.keyP3)
            {
                _gameManager.AddPoint();
                _gameManager.keyP3 = false;
            }
            addPoints = false;
        }
        else if (_gameManager.pointsPuzzle3 != 0 && !addPoints){
            _gameManager.pointsPuzzle3 --;
            addPoints = true;
        }
    }
}
