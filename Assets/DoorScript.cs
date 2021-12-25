using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject door;

    [SerializeField] private bool isEnabled = true;
    private Animator animator;
    [SerializeField] private GameObject[] statusLights;

    [SerializeField] private Material enabledColor;
    [SerializeField] private Material disabledColor;
    [SerializeField] private Material openColor;

    private Material[] newMaterials;
    
    private static readonly int CharacterNearby = Animator.StringToHash("character_nearby");

    // Start is called before the first frame update
    void Start()
    { 
        animator = door.GetComponent<Animator>();
        Debug.Log("Hallo debug here");
        if (isEnabled)
        {
            foreach (var statusLight in statusLights)
            { 
                newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
                newMaterials[1] = enabledColor;
                statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
            }
        }
        else
        {
            foreach (var statusLight in statusLights)
            { 
                newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
                newMaterials[1] = disabledColor;
                statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
            }
        }
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }


    private void OnCollisionEnter(Collision other)
    {
        if (isEnabled)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool(CharacterNearby, true);
                Debug.Log("Enter Door Trigger");
                foreach (var statusLight in statusLights)
                { 
                    newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
                    newMaterials[1] = openColor;
                    statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
                }
            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (isEnabled)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool(CharacterNearby, false);
                Debug.Log("Exit Door Trigger");
                
                foreach (var statusLight in statusLights)
                { 
                    newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
                    newMaterials[1] = enabledColor;
                    statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
                }
            }
            else
            {
                foreach (var statusLight in statusLights)
                { 
                    newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
                    newMaterials[1] = disabledColor;
                    statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
                }
            }
        }
    }
}