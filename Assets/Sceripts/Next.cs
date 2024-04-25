using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public GameObject titleScreenParent;
    public void nekst()
    {
        titleScreenParent.SetActive(false);
    }
}