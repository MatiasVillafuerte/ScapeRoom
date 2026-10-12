using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    private bool puzzleSolved = false;

    public void SolvePuzzle()
    {
        puzzleSolved = true;
        Debug.Log("Puzzle solved successfully");
    }

    public bool IsPuzzleSolved()
    {
        return puzzleSolved;
    }
}