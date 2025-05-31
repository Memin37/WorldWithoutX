using UnityEngine;

public class Interaction : MonoBehaviour
{
    public float interactionRange = 3f; // Ne kadar uzaktaki objelerle etkile�im kurulabilir
    public LayerMask interactableLayer; // Hangi katmandaki objelere etkile�im var

    void Update()
    {
        // Kamera merkezinden ileriye bir ���n g�nder
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange, interactableLayer))
        {
            // E tu�una bas�ld�ysa
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Etkile�ime ge�ilebilir objede Interactable ad�nda bir component var m�?
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}
