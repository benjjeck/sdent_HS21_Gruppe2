using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    
    public GameObject door;
    private Animator animator;

    private int boolHash = Animator.StringToHash("character_nearby");
    // Start is called before the first frame update
    void Start()
    {
        animator = door.GetComponent<Animator>();

        Debug.Log("Hallo debug here");
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("character_nearby", true);
            Debug.Log("Enter Door Trigger");

        }

        
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("character_nearby", false);
            Debug.Log("Exit Door Trigger");
        }
        

    }
}
