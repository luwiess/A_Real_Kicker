using UnityEngine;

public class VictoryCondition : MonoBehaviour
{
    public GameObject p1VictoryCanvas; 
    public GameObject p2VictoryCanvas; 
    bool yep = false;
    void Update()
    {
        if (yep == false)
        {
            if (GameObject.FindGameObjectWithTag("Player_1").GetComponent<PlayerAttack>().health <= 0)
            {
                p2VictoryCanvas.SetActive(true);
                yep = true;
            }
            else if (GameObject.FindGameObjectWithTag("Player_2").GetComponent<PlayerAttack>().health <= 0)
            {
                p1VictoryCanvas.SetActive(true);
                yep = true;
            }
        }
    }
}