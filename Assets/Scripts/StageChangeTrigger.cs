
using UnityEngine;

public class StageChangeTrigger : MonoBehaviour
{

    [SerializeField] private GameObject StageManager;
    [Range(1,3)]
    [SerializeField] private int StagetoEnd; 
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Registered");

        
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Collision with Player Registered");
                switch (StagetoEnd)
                {
                    case 1 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_2(); break;
                    case 2 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_3(); break;
                    case 3 : StageManager.GetComponent<StageHandlerScript>().InitializeStage_4(); break;
                }
            }
        
    }
}
