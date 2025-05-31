using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.Log("Bu obje ile etkileþime geçildi: " + gameObject.name);
        // Buraya override ederek özel etkileþimler tanýmlayabilirsin
    }
}