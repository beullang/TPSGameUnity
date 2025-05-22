using UnityEngine;

[RequireComponent(typeof(CharacterController))] //
public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float gravity = -9.91f; //기본 중력값

    private float verticalVelocity; //상하 방향 속도

    private CharacterController cc;
    private PlayerInputReader inputReader;
    public Transform cameraTransform;

    private void Awake()
    {
        cc = GetComponent<CharacterController>();
        inputReader = GetComponent<PlayerInputReader>();
    }

    private void Update()
    {
        Vector2 move = inputReader.MoveInput;
        Vector3 moveDirection = cameraTransform.right * move.x + cameraTransform.forward * move.y;
        moveDirection.y = 0f;

        if (cc.isGrounded)
            verticalVelocity = -1f;
        else
            verticalVelocity += gravity * Time.deltaTime;

        moveDirection.y = verticalVelocity;
        cc.Move(moveDirection*moveSpeed*Time.deltaTime);
    }
}
