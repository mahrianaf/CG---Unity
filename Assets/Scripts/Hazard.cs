using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        Destroy(gameObject);
    }
}*/

public class Hazard : MonoBehaviour
{
    public int vida = 2; //precisa de 2 tiros
    public GameObject pixelEffectPrefab; 

    public void TomarDano()
    {
        vida--; 
        
        if (vida <= 0) 
        {
            if (pixelEffectPrefab != null)
            {
                Instantiate(pixelEffectPrefab, transform.position, Quaternion.identity);
            }
            Destroy(gameObject); //Destrói o esqueleto
        }
    }
}
