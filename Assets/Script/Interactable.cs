using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.Log("Bu obje ile etkileşime geçildi: " + gameObject.name);
        // Buraya override ederek özel etkileşimler tanımlayabilirsin
    }
}