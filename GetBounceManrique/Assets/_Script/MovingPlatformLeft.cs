using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformLeft : MonoBehaviour
{
    public float range;
    public float speed;
    private float rightRange;
    private float leftRange;
    private bool isMovingLeft;

    // Start is called before the first frame update
    void Start()
    {
        rightRange = transform.position.x + range;
        leftRange = transform.position.x - range;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovingLeft)
        {

            if (transform.position.x > leftRange)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else
            {
                isMovingLeft = false;
            }
        }
        else
        {
            if (transform.position.x < rightRange)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else
            {
                isMovingLeft = true;
            }
        }
    }
}
