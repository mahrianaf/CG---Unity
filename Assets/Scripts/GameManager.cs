using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hazardPrefab;
    public int maxHazardsToSpawn = 2;
    void Start()
    {
        StartCoroutine(SpawnHazards());
    }

    private IEnumerator SpawnHazards()
    {
        //Numero de caixas despencando junto
        var hazardToSpawn = Random.Range(1,maxHazardsToSpawn);

        for(int i=0; i< hazardToSpawn; i++)
        {
            var x= Random.Range(-7,7); 
            var drag= Random.Range(0f,2f);
            
            //Faz o bloco despencar de qualquer posicao entre -7 e 7
            var hazard= Instantiate(hazardPrefab, new Vector3(x,11,0), Quaternion.identity);
            hazard.GetComponent<Rigidbody>().drag=drag; //Resistencia do ar varia entre 0 e 2 
        }

        var timeToWait= Random.Range(0.5f, 1.5f);
        yield return new WaitForSeconds(timeToWait);
        //Chama a funcao recursivamente (varios blocos despencam em sequencia)
        yield return SpawnHazards();
    }
}
