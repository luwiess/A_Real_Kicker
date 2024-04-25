using UnityEngine;
using UnityEngine.UI;

public class P2_StaminaSliderUpdater : MonoBehaviour
{
    public PlayerAttack player2; 
    public Slider P2StaminaSlider; 
    void Update()
    {
        if (player2 != null && P2StaminaSlider != null)
        {
            P2StaminaSlider.value = player2.stamina;
        }
    }
}