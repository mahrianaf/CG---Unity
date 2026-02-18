using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Pistol : MonoBehaviour
{
    public Transform muzzle; 
    public float range = 50f;

    void Start()
    {
        // Escuta o evento de apertar o gatilho do controle VR
        XRGrabInteractable grabber = GetComponent<XRGrabInteractable>();
        grabber.activated.AddListener(x => Shoot());
    }

    public void Shoot()
    {
        RaycastHit hit;
        // Lança o laser da ponta da arma (muzzle) para frente
        if (Physics.Raycast(muzzle.position, muzzle.forward, out hit, range))
        {
            // Tenta encontrar o script Hazard no que o laser acertou
            Hazard skeleton = hit.transform.GetComponent<Hazard>();
            if (skeleton != null)
            {
                skeleton.TomarDano(); 
            }
        }
    }
}