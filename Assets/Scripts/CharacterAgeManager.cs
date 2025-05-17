using UnityEngine;

public class CharacterAgeManager : MonoBehaviour
{
    public GameObject[] characterModels; // 0=3yr, 1=33yr, ...
    private int currentAgeIndex = 0;

    public void AdvanceAge()
    {

        if (currentAgeIndex >= characterModels.Length - 1)
            return;


        characterModels[currentAgeIndex].SetActive(false);

        currentAgeIndex++;


        characterModels[currentAgeIndex].SetActive(true);
    }
}
