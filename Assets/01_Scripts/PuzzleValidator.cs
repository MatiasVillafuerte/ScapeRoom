
using UnityEngine;

public class PuzzleValidator : MonoBehaviour
{
    public int correctAnswer = 1234;

    public bool ValidateAnswer(int answer)
    {
        if (answer == correctAnswer)
        {
            Debug.Log("Puzzle solved correctly");
            return true;
        }

        Debug.Log("Incorrect puzzle answer");
        return false;
    }

    [ContextMenu("Test Correct Answer")]
    public void TestCorrectAnswer()
    {
        ValidateAnswer(1234);
    }

    [ContextMenu("Test Incorrect Answer")]
    public void TestIncorrectAnswer()
    {
        ValidateAnswer(9999);
    }
}
