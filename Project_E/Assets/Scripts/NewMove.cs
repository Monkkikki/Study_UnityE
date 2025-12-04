using UnityEngine;
using UnityEngine.InputSystem;

public class NewMove : MonoBehaviour
{
    [SerializeField] float speed = 5f; // 5f = float 형 5 = 10진수 5, SerializedField = 기획자를 위한
    private Vector2 moveInput;

    void Update()
    {
        Vector3 dir = new Vector3(moveInput.x, 0, moveInput.y);
        transform.Translate(dir * speed * Time.deltaTime); // Time.deltaTime = 1초에
    }

    public void OnMove(InputValue value) // OnMove = Move함수가 리스너 함수로 변형된 형태
    {
        moveInput = value.Get<Vector2>();
    }
}