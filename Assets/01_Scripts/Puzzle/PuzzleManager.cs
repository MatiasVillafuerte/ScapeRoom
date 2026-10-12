using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private int requiredKeys = 3;

    private int collectedKeys = 0;

    public void CollectKey()
    {
        collectedKeys++;

        Debug.Log("Keys collected: " + collectedKeys);
    }

    public bool HasAllKeys()
    {
        return collectedKeys >= requiredKeys;
    }
}