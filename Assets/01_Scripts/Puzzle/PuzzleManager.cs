using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private int requiredKeys = 3;

    private int collectedKeys = 0;
    private bool puzzleSolved = false;

    public void CollectKey()
    {
        if (puzzleSolved)
            return;

        collectedKeys++;

        Debug.Log("Keys collected: " + collectedKeys);

        if (HasAllKeys())
        {
            SolvePuzzle();
        }
    }

    public bool HasAllKeys()
    {
        return collectedKeys >= requiredKeys;
    }

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