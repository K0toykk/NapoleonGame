using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoving : MonoBehaviour
{

    public float speed;


    private int angle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            angle = angle + 1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            angle = angle - 1;
        }

        transform.position = new Vector3(transform.position.x + (speed * angle), transform.position.y, transform.position.z);
    }
}
