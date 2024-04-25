using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject titleScreenParent;
    public void PlayGame()
    {
        titleScreenParent.SetActive(false);
    }
}