using UnityEngine;

public class StageHandlerScript : MonoBehaviour
{
    [Header("Stage 1")]
    [SerializeField] private GameObject[] Stage1DisabledDoors;
    
    [Header("Stage 2")]
    [SerializeField] private GameObject[] Stage2DisabledDoors;
    [SerializeField] private GameObject[] Stage2EnabledDoors;

    [Header("Stage 3")]
    [SerializeField] private GameObject[] Stage3DisabledDoors;
    [SerializeField] private GameObject[] Stage3EabledDoors;

    [Header("Stage 4")]
    [SerializeField] private GameObject[] Stage4DisabledDoors;
    [SerializeField] private GameObject[] Stage4EnabledDoors;


    // Start is called before the first frame update
    void Start()
    {
        InitialzieStage_1();
    }

    void InitialzieStage_1()
    {
        foreach (var door in Stage1DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
    }

    void InitializeStage_2()
    {
        foreach (var door in Stage2DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
    }
}