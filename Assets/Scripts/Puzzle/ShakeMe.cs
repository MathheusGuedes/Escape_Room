using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeMe : MonoBehaviour
{
    
    [SerializeField]
    private bool shaking = false;
    [SerializeField]
    private Vector3 originalPos;
    [SerializeField]
    private float  magnitude;
    [SerializeField]
    private GameManager _gameManager;
    
    void Awake()
    {
        originalPos = transform.position;
    }

    void Update()
    {
        if(_gameManager.loss)
        {
            StartCoroutine("ShakeNow");
            _gameManager.loss = false;
        }
        if(shaking)
        {
            float x = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(originalPos.x + x, originalPos.y, originalPos.z);               
        }
        
    }

     IEnumerator ShakeNow()
    {
        

        if(!shaking) shaking = true;

        yield return new WaitForSeconds(0.65f);

        shaking = false;
    }


    
}