using UnityEngine;

public class PuzzleTester : MonoBehaviour
{
    [SerializeField] private PuzzleManager puzzleManager;

    private void Update()
    {
        // Caso 12: verificacion del controlador del jugador.
        if (Input.GetKeyDown(KeyCode.K))
        {
            puzzleManager.CollectKey();

            Debug.Log("Puzzle solved: " +
                puzzleManager.IsPuzzleSolved());
        }
    }
}