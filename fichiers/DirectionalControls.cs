using UnityEngine;
using UnityEngine.InputSystem;

public class DirectionalControls : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody rigidBody;

        void Start()
    {
        // Get the RigidBody Component
        rigidBody = gameObject.GetComponent<Rigidbody>();

    }

    void Update()
    {
        Vector2 input = Vector2.zero;

        if (Keyboard.current != null)
        {
            input.x = (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed ? 1 : 0)
                    - (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed ? 1 : 0);

            input.y = (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed ? 1 : 0)
                    - (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed ? 1 : 0);

        }

        Vector3 forceDirection = new Vector3(input.x, 0f, input.y);

        rigidBody.AddForce(forceDirection * speed, ForceMode.Force);
    }
}
