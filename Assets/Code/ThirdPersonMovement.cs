using UnityEngine;
using Mirror;

public class ThirdPersonMovement : NetworkBehaviour
{
    public CharacterController controller;
    Transform cam;

    public float speed = 5f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer) { return; }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float verticle = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, verticle).normalized;

        if(direction.magnitude >= 0.1)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
