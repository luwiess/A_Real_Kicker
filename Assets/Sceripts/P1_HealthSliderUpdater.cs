using UnityEngine;
using UnityEngine.UI;

public class P1_HealthSliderUpdater : MonoBehaviour
{
    public PlayerAttack player1; 
    public Slider P1healthSlider; 
    void Update()
    {
        if (player1 != null && P1healthSlider != null)
        {
            P1healthSlider.value = player1.health;
        }
    }
}