using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerAimContoller : MonoBehaviour
{
    public float sensyX = 150f; //마우스 민감도 x축
    public float sensyY = 100f; //마우스 민감도 y축
    public float minPitch = -60f;  //최소 각도
    public float maxPithc = 70f;
    private float pitch = 0f;

    public PlayerInputReader input; //입력정의한 클래스

    private void Update()
    {
        float mouseX = input.MouseX * sensyX * Time.deltaTime;  //
        float mouseY = input.MouseY * sensyY * Time.deltaTime;

        //Y축 좌우 회전 처리
        transform.Rotate(Vector3.up, mouseX, Space.World); //월드축 기준으로 회전

        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, minPitch, maxPithc); //각도 잠금

        Vector3 currentEuler = transform.localEulerAngles; //
        currentEuler.x = pitch;
        transform.localEulerAngles = currentEuler;
        
    }
}
