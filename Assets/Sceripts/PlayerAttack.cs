using UnityEngine;
using System.Collections;
public class PlayerAttack : MonoBehaviour
{
    private Animator animator;
    private Collider punchCollider;
    private Collider hitBoxCollider;
    public AudioSource audioSource;

    public int health = 100;
    public int stamina = 100;

    void Start()
    {
        animator = GetComponent<Animator>();
        Transform hitBoxTransform = transform.Find("HitBox");
        if (hitBoxTransform != null)
        {
            hitBoxCollider = hitBoxTransform.GetComponent<Collider>();
        }
        else
        {
            Debug.LogError("HitBox not found under player GameObject.");
        }
        Transform punchTransform = transform.Find("Punch");
        if (punchTransform != null)
        {
            punchCollider = punchTransform.GetComponent<Collider>();
            punchCollider.enabled = false;
        }
        else
        {
            Debug.LogError("Punch object not found under player GameObject.");
        }
        StartCoroutine(IncreaseStamina());
    }

    void Update()
    {
        if (gameObject.CompareTag("Player_1"))
        {
            if (Input.GetKeyDown(KeyCode.F) && stamina >= 10)
            {
                animator.SetTrigger("PunchLeftTrigger");
                EnablePunchCollider();
                if (stamina > 0)
                {
                    stamina -= 10;
                }
            }
            else if (Input.GetKeyDown(KeyCode.G) && stamina >= 10)
            {
                animator.SetTrigger("PunchRightTrigger");
                EnablePunchCollider();
                if (stamina > 0)
                {
                    stamina -= 10;
                }
            }
        }
        else if (gameObject.CompareTag("Player_2") && stamina >= 10)
        {
            if (Input.GetKeyDown(KeyCode.Period))
            {
                animator.SetTrigger("PunchLeftTrigger");
                EnablePunchCollider();
                if (stamina > 0)
                {
                    stamina -= 10;
                }
            }
            if (Input.GetKeyDown(KeyCode.Slash) && stamina >= 10)
            {
                animator.SetTrigger("PunchRightTrigger");
                EnablePunchCollider();
                if (stamina > 0)
                {
                    stamina -= 10;
                }
            }
        }
        if(stamina <= 10)
        {
            Debug.Log("Stamina at or below 0"); ;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Punch"))
        {
            animator.SetTrigger("GetHitTrigger");
            health -= 10; 
            if (audioSource != null)
            {
                audioSource.PlayOneShot(audioSource.clip);
            }
            if (health <= 0)
            {
                Debug.Log("Player defeated!");
            }
        }
    }
    private void EnablePunchCollider()
    {
        punchCollider.enabled = true;
        StartCoroutine(DisablePunchColliderAfterDelay());
    }
    private IEnumerator DisablePunchColliderAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        punchCollider.enabled = false;
    }
    private IEnumerator IncreaseStamina()//fixed :)
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            stamina = Mathf.Min(stamina + 5, 100);
        }
    }
}