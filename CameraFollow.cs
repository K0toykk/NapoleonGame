using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;


    public float firstBorder;
    public float secondBorder;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!(player.transform.position.x < firstBorder || player.transform.position.x > secondBorder))
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

        }
    }

}
