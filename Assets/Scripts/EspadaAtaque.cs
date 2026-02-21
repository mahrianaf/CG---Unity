using UnityEngine;

public class EspadaAtaque : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Procura o script Hazard no objeto que a espada bateu
        Hazard esqueleto = collision.gameObject.GetComponent<Hazard>();

        if (esqueleto != null)
        {
            esqueleto.TomarDano();
            Debug.Log("Espada atingiu o esqueleto!");
        }
    }
}
