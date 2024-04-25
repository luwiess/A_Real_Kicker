using UnityEngine;
using UnityEngine.UI;

public class P1_StaminaSliderUpdater : MonoBehaviour
{
    public PlayerAttack player1; 
    public Slider P1StaminaSlider; 
    void Update()
    {
        if (player1 != null && P1StaminaSlider != null)
        {
            P1StaminaSlider.value = player1.stamina;
        }
    }
}