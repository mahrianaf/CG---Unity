using UnityEngine;

public class EsqueletoSpawner : MonoBehaviour
{
    public GameObject esqueletoPrefab; // Arraste o prefab do esqueleto aqui
    public Transform localDeSpawn;    // Um objeto vazio onde o esqueleto vai aparecer
    public int quantidade = 1;         // Quantos nascem por clique

    // Esta função será chamada pelo botão
    public void CriarEsqueleto()
    {
        if (esqueletoPrefab != null && localDeSpawn != null)
        {
            for (int i = 0; i < quantidade; i++)
            {
                // Cria o esqueleto na posição e rotação do localDeSpawn
                Instantiate(esqueletoPrefab, localDeSpawn.position, localDeSpawn.rotation);
            }
            Debug.Log("Esqueleto spawnado!");
        }
        else
        {
            Debug.LogWarning("Faltam referências no EsqueletoSpawner!");
        }
    }
}