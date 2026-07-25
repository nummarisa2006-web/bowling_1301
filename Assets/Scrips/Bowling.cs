using UnityEngine;
using UnityEngine.InputSystem;

public class Bowling : MonoBehaviour
{
    [SerializeField]
    private Rigidbidt rd;

    [SerializeField]
    private int forcePower;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<RigidBody>();
    }
     
    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKry.wasPressedThidFrame)
            ShootBall();

        if (keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            MoveRight();

        if (keyboard.current.leftArrowKey.isPressed || Keyboard.current.dKey.isPressed)
            MoveLeft();
    }

    private void ShootBall()
    {
        rb.AddForce(Vector3.forward * forcePower, ForceMode.Impulse);
    }

    private void MoveRight()
    {
        transform.postition += new Vector3(0.5f, 0f, 0f) * Time.deltaTime;
    }

    private void MoveLeft()
    {
        transform.postition += new Vector3(0.5f, 0f, 0f) * Time.deltaTime;
    }
}
