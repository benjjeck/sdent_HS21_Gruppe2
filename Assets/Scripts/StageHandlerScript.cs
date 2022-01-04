using UnityEngine;
using UnityEngine.Serialization;

public class StageHandlerScript : MonoBehaviour
{
    [Header("Stage 1")]
    [SerializeField] private GameObject[] Stage1DisabledDoors;
    
    [Header("Stage 2")]
    [SerializeField] private GameObject[] Stage2DisabledDoors;
    [SerializeField] private GameObject[] Stage2EnabledDoors;

    [Header("Stage 3")]
    [SerializeField] private GameObject[] Stage3DisabledDoors;
    [SerializeField] private GameObject[] Stage3EnabledDoors;

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
        Debug.Log("Init Stage 1");
        foreach (var door in Stage1DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
    }

    public void InitializeStage_2()
    {
        Debug.Log("Init Stage 2");

        foreach (var door in Stage2DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
        foreach (var door in Stage2EnabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(true);
        }
    }
    
    public void InitializeStage_3()
    {
        Debug.Log("Init Stage 3");

        foreach (var door in Stage3DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
        foreach (var door in Stage3EnabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(true);
        }
    }
    
    public void InitializeStage_4()
    {
        Debug.Log("Init Stage 4");

        foreach (var door in Stage4DisabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(false);
        }
        foreach (var door in Stage4EnabledDoors)
        {
            door.GetComponentInChildren<DoorScript>().SetEnabled(true);
        }
    }
}