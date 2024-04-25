using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Animator animator;
    private string horizontalAxis;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        if (gameObject.CompareTag("Player_1"))
        {
            horizontalAxis = "Horizontal_P1";
        }
        else if (gameObject.CompareTag("Player_2"))
        {
            horizontalAxis = "Horizontal_P2";
        }
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis(horizontalAxis);
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + movement);
        if (horizontalInput > 0)
        {
            animator.ResetTrigger("IdleTrigger");
            if (gameObject.CompareTag("Player_1"))
            {
                animator.SetTrigger("RunForwardTrigger");
            }
            else if (gameObject.CompareTag("Player_2"))
            {
                animator.SetTrigger("RunBackwardTrigger");
            }
        }
        else if (horizontalInput < 0)
        {
            animator.ResetTrigger("IdleTrigger");
            if (gameObject.CompareTag("Player_1"))
            {
                animator.SetTrigger("RunBackwardTrigger");
            }
            else if (gameObject.CompareTag("Player_2"))
            {
                animator.SetTrigger("RunForwardTrigger");
            }
        }
        else
        { animator.ResetTrigger("RunBackwardTrigger"); animator.ResetTrigger("RunForwardTrigger"); animator.SetTrigger("IdleTrigger"); };
    }
}