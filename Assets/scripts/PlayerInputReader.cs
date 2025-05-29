using UnityEditor;
using UnityEngine;

//Input system  배우기전ㅇㅔ 코드로 입력ㅇㅡㄹ 나눠서 값을 받아서 사용
public class PlayerInputReader : MonoBehaviour
{
    public Vector3 MoveInput { get; private set; } //프로퍼티
    public bool JumpPressed { get; private set; }

    //public bool IsFireing = Input.GetButton("Fire1"); //왼쪽클릭
    public float MouseX { get; private set; } //마우스 x위치 
    public float MouseY { get; private set; }// y위치

    private void Update()
    {
        MoveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        JumpPressed = Input.GetButtonDown("Jump");
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
    }
}
