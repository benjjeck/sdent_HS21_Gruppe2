using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject door;

    [SerializeField] private bool isEnabled = true;
   
    private Animator animator;
    [SerializeField] private GameObject[] statusLights;
    [SerializeField] private Material enabledColor;
    [SerializeField] private Material disabledColor; 

    private Material[] newMaterials;
    
    private static readonly int CharacterNearby = Animator.StringToHash("character_nearby");

    // Start is called before the first frame update
    void Start()
    { 
        animator = door.GetComponent<Animator>();
        if (isEnabled)
        {
            SetStatusColor(enabledColor);
        }
        else
        {
            SetStatusColor(disabledColor);
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (isEnabled)
    //     {
    //         
    //     }   
    // }


    private void OnCollisionEnter(Collision other)
    {
        if (isEnabled)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool(CharacterNearby, true);
                
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
            }
            
        }
    }


    public void SetEnabled(bool intent)
    {
        if (intent)
        {
            SetStatusColor(enabledColor);
            isEnabled = true;
        }
        else
        {
            SetStatusColor(disabledColor);
            isEnabled = false;
        }
    }


    private void SetStatusColor(Material newColor)
    {
        foreach (var statusLight in statusLights)
        {
            newMaterials = statusLight.GetComponent<MeshRenderer>().materials;
            newMaterials[1] = newColor;
            statusLight.GetComponent<MeshRenderer>().materials = newMaterials;
            statusLight.GetComponentInChildren<Light>().color = newColor.color;

        }
    }
}
