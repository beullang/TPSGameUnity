using UnityEngine;

[RequireComponent(typeof(CharacterController))] //
public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float gravity = -9.91f; //�⺻ �߷°�

    public PlayerAnimationController controller; 

    private float verticalVelocity; //���� ���� �ӵ�
    private CharacterController cc;
    private PlayerInputReader inputReader;
    public Transform cameraTransform;
    

    private void Awake()
    {
        controller = GetComponent<PlayerAnimationController>(); //�ִϸ��̼� ���� ��ũ��Ʈ ����
        cc = GetComponent<CharacterController>(); //ĳ���� ��Ʈ�ѷ� ������Ʈ
        inputReader = GetComponent<PlayerInputReader>(); //���� �Է� ���
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
        cc.Move(moveDirection*moveSpeed*Time.deltaTime); //�����̰� �ϴ��ڵ�

        //�ִϸ��̼� �����
        float floatSpeed = new Vector3(moveDirection.x ,0f, moveDirection.z).magnitude;
        //Debug.Log(floatSpeed);
        controller.UpdateMoveAnim(floatSpeed);
    }
}
