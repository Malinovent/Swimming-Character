using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float turnSpeed = 90;

    void Update()
    {
        //I would prefer to use the new input system, but this is a simple example using the old input system.
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");
        
        transform.Rotate(Vector3.up, horizontal * turnSpeed * Time.deltaTime);
        
        Vector3 movement = transform.forward * vertical * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
        
        animator.SetFloat("Speed", vertical);
        animator.SetFloat("Turn", horizontal);
    }
}
