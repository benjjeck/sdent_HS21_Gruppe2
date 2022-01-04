using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using Valve.VR;

public class StageChangeTrigger : MonoBehaviour
{

    [SerializeField] private GameObject StageManager;
    [Range(1,3)]
    [SerializeField] private int StagetoEnd; 
    private void OnCollisionEnter(Collision other)
    {
        
            if (other.gameObject.CompareTag("Player"))
            {
                switch (StagetoEnd)
                {
                    case 1 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_2(); break;
                    case 2 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_3(); break;
                    case 3 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_4(); break;
                }
            }
        
    }
}
