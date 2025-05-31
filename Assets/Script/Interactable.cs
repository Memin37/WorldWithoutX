using UnityEngine;

public class Interactable : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.Log("Bu obje ile etkile�ime ge�ildi: " + gameObject.name);
        // Buraya override ederek �zel etkile�imler tan�mlayabilirsin
    }
}