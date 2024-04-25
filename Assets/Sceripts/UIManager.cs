using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public RectTransform p1HealthBar;
    public RectTransform p2HealthBar;
    public RectTransform p1StaminaBar;
    public RectTransform p2StaminaBar;
    public PlayerAttack player1;
    public PlayerAttack player2; 

    void Update()
    {
        UpdateUI(player1.health, player1.stamina, p1HealthBar, p1StaminaBar);
        UpdateUI(player2.health, player2.stamina, p2HealthBar, p2StaminaBar);
    }

    void UpdateUI(int health, int stamina, RectTransform healthBar, RectTransform staminaBar)
    {
        float healthX = MapValue(health, 0, 100, -100, 100);
        float staminaX = MapValue(stamina, 0, 100, -100, 100);
        healthBar.localPosition = new Vector3(healthX, healthBar.localPosition.y, healthBar.localPosition.z);
        staminaBar.localPosition = new Vector3(staminaX, staminaBar.localPosition.y, staminaBar.localPosition.z);
    }
    float MapValue(float value, float fromMin, float fromMax, float toMin, float toMax)
    {
        return (value - fromMin) / (fromMax - fromMin) * (toMax - toMin) + toMin;
    }
}