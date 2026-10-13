using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int initializationCount = 0;

    void Start()
    {
        Initialize(); 
        Debug.Log("GameManager iniciado");
    }

    public void Initialize()
    {
        initializationCount++;

        Debug.Log("Initialize ejecutado: " + initializationCount);

        if (initializationCount > 1)
        {
            Debug.LogError("ERROR: El juego se inicializo mas de una vez.");
        }
    }
}