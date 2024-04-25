using UnityEngine;
using UnityEngine.SceneManagement;

public class TutExit : MonoBehaviour
{
    public GameObject titleScreenParent;
    public void Texit()
    {
        titleScreenParent.SetActive(false);
    }
}