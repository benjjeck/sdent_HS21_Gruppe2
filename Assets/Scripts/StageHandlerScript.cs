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

    private int stage = 0;

    // Start is called before the first frame update
    void Start()
    {
        InitialzieStage_1();
    }

    void InitialzieStage_1()
    {
        if (stage == 0)
        {
            Debug.Log("Init Stage 1");
            foreach (var door in Stage1DisabledDoors)
            {
                door.GetComponentInChildren<DoorScript>().SetEnabled(false);
            }

            stage = 1;
        }
    }

    public void InitializeStage_2()
    {
        if (stage == 1)
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

            stage = 2;
        }
    }
    
    public void InitializeStage_3()
    {
        if (stage == 2)
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

            stage = 3;
        }
    }
    
    public void InitializeStage_4()
    {
        if (stage == 3)
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

            stage = 4;
        }
    }
}