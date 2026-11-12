using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private float speed = 10f;
    private Vector2 moveInput;  //  入力処理用

    //  マウス座標
    private void Start()
    {
    }

    private void Update()
    {
        //  移動
        Vector3 move3D = new Vector3(moveInput.x, 0, moveInput.y);

        transform.Translate(move3D * speed * Time.deltaTime);
    }
}
