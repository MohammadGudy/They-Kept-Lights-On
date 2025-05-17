using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Transform insideReference; 
    public CharacterAgeManager ageManager;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        Vector3 toPlayer = other.transform.position - insideReference.position;


        if (Vector3.Dot(transform.forward, toPlayer.normalized) > 0)
        {

            Debug.Log("Exited → Advance age");
            ageManager.AdvanceAge();
        }
        else
        {
            Debug.Log("Entered from outside → ignore");
        }
    }
}
