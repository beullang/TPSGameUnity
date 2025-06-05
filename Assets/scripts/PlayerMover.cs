using UnityEngine;

[RequireComponent(typeof(CharacterController))] //
public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float gravity = -9.91f; //기본 중력값

    public PlayerAnimationController controller; 

    private float verticalVelocity; //상하 방향 속도
    private CharacterController cc;
    private PlayerInputReader inputReader;
    public Transform cameraTransform;
    

    private void Awake()
    {
        controller = GetComponent<PlayerAnimationController>(); //애니메이션 동작 스크립트 연결
        cc = GetComponent<CharacterController>(); //캐릭터 컨트롤러 컴포넌트
        inputReader = GetComponent<PlayerInputReader>(); //유저 입력 담당
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
        cc.Move(moveDirection*moveSpeed*Time.deltaTime); //움직이게 하는코드

        //애니메이션 실행부
        float floatSpeed = new Vector3(moveDirection.x ,0f, moveDirection.z).magnitude;
        //Debug.Log(floatSpeed);
        controller.UpdateMoveAnim(floatSpeed);
    }
}
