using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hazardPrefab;
    public int maxHazardsToSpawn = 2;
    
    [Header("Configuração do Alerta")]
    public GameObject objetoQueSobe; 
    public float alturaYFinal = 5f;  
    public float velocidadeSubida = 2f;
    public float delayAntesDaChuva = 2f; 

    private bool estaAtivo = false;

    public void AtivarChuva()
    {
        if (!estaAtivo) 
        {
            estaAtivo = true;
            StartCoroutine(SequenciaDeAtaque());
        }
    }

    private IEnumerator SequenciaDeAtaque()
    {
        if (objetoQueSobe != null)
        {
            Vector3 posicaoAlvo = new Vector3(objetoQueSobe.transform.position.x, alturaYFinal, objetoQueSobe.transform.position.z);
            
            // Sobe suavemente até a altura desejada
            while (Vector3.Distance(objetoQueSobe.transform.position, posicaoAlvo) > 0.01f)
            {
                objetoQueSobe.transform.position = Vector3.MoveTowards(objetoQueSobe.transform.position, posicaoAlvo, velocidadeSubida * Time.deltaTime);
                yield return null; //Espera o próximo frame
            }
        }

        yield return new WaitForSeconds(delayAntesDaChuva);

        StartCoroutine(SpawnHazards());
    }
    private IEnumerator SpawnHazards(){

        //var hazardToSpawn = Random.Range(1, maxHazardsToSpawn + 1);
        
        for (int i = 0, x=-6; i < 5; i++, x=x+3)
        {
            //var x = Random.Range(-8, 8);
            Instantiate(hazardPrefab, new Vector3(x, 11, 2), hazardPrefab.transform.rotation);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }

        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        
        //if (estaAtivo) yield return SpawnHazards();
    }
}