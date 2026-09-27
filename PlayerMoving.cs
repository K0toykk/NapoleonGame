using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoving : MonoBehaviour
{

    public float speed;

    private int angle;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        angle = 0;

        if (Keyboard.current.dKey.isPressed)
        {
            angle = angle + 1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            angle = angle - 1;
        }

        if (!Keyboard.current.dKey.isPressed && !Keyboard.current.aKey.isPressed)
        {
            angle = 0;
        }


        if (angle == -1)
        {
            if (Time.timeScale != 0f)
            {
                sr.flipX = true;
            }
        }

        if (angle == 1)
        {
            if (Time.timeScale != 0f)
            {
                sr.flipX = false;
            }
        }
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + (speed * angle), transform.position.y, transform.position.z);
    }
}
