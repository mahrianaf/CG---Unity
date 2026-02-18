using UnityEngine;

public class TesteMouseBotao : MonoBehaviour
{
    public GameManager meuGameManager; 

    private void OnMouseDown()
    {
        Debug.Log("Ativar animação!");
        if (meuGameManager != null)
        {
            meuGameManager.AtivarChuva();
        }
        else
        {
            Debug.LogError("Adicionar GameManager para o script do botão!");
        }
    }
}