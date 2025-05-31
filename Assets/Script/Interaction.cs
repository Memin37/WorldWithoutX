using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float interactionRange = 3f; // Ne kadar uzaktaki objelerle etkileþim kurulabilir
    public LayerMask interactableLayer; // Hangi katmandaki objelere etkileþim var

    void Update()
    {
        // Kamera merkezinden ileriye bir ýþýn gönder
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange, interactableLayer))
        {
            // E tuþuna basýldýysa
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Etkileþime geçilebilir objede Interactable adýnda bir component var mý?
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}
