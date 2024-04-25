using UnityEngine;
using UnityEngine.UI;

public class P2_HealthSliderUpdater : MonoBehaviour
{
    public PlayerAttack player2; 
    public Slider P2healthSlider; 

    void Update()
    {
        if (player2 != null && P2healthSlider != null)
        {
            P2healthSlider.value = player2.health;
        }
    }
}