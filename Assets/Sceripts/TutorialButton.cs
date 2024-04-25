using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    public GameObject TutorialScreen;
    public void Tutorail()
    {
        TutorialScreen.SetActive(true);
    }
}