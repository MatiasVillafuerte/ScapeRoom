
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 3f;
    public float openAngle = 90f;

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openedRotation;

    void Start()
    {
        closedRotation = transform.localRotation;

        openedRotation = closedRotation *
                         Quaternion.Euler(0f, openAngle, 0f);
    }

    void Update()
    {
        if (player == null)
        {
            return;
        }

        float distance = Vector3.Distance(
            player.position,
            transform.position
        );

        if (distance <= interactionDistance &&
            Input.GetKeyDown(KeyCode.E))
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            transform.localRotation = openedRotation;
            Debug.Log("Door opened");
        }
        else
        {
            transform.localRotation = closedRotation;
            Debug.Log("Door closed");
        }
    }
}
