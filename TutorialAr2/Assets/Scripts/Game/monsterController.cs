using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class monsterController : MonoBehaviour
{
    
    
    public float movementSpeed = 0.3f;
        
    private GameObject target;
    public GameUI uiManager;
    

    void Start()
    {
        uiManager = GameObject.Find("UIManager").GetComponent<GameUI>();
        target = GameObject.Find("AR Session Origin").transform.GetChild(0).transform.GetChild(0).gameObject;
        
    }
 
    void Update()
    {
        
        Vector3 forward = target.transform.position - transform.position;
        
        transform.Translate(forward.normalized * Time.deltaTime * movementSpeed);

        

    }

    
    

    private void OnTriggerEnter(Collider other)
    {

       
        if(other.gameObject.CompareTag("Player"))
        {

            // collision with player

            
            uiManager.SubstractHealth();
            Destroy(gameObject);

            
            
            
        }
    }
    
}
