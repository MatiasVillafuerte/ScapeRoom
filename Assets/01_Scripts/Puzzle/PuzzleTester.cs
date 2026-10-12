using UnityEngine;

public class PuzzleTester : MonoBehaviour
{
    [SerializeField] private PuzzleManager puzzleManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            puzzleManager.CollectKey();

            Debug.Log("Puzzle solved: " +
                puzzleManager.IsPuzzleSolved());
        }
    }
}