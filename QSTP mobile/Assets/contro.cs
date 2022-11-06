using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contro : MonoBehaviour
{
    public float rotateSpeed = 10f;
    bool updown;
    private Gyroscope gyro;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
       // transform.Rotate(0, 0, Input.gyro.rotationRate.z);
        //transform.rotation = Input.gyro.attitude;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
// Vector2 touchposition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x > ((Screen.width) / 2))
                {
                    //transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    updown = true;
                   // transform.rotation =  Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x,transform.rotation.y,transform.rotat),3f);
                }
                else
                {
                    //transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    updown = false;
                }
            }
            if (touch.phase == TouchPhase.Stationary)
            {
                if (touch.position.x > ((Screen.width) / 2))
                {
                    //transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    updown = true;
                }
                else
                {
                    //transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    updown = false;
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x > ((Screen.width) / 2))
                {
                    //transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                    updown = true;
                }
                else
                {
                    //transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                    updown = false;
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                float timer = 100;
                if(timer>0)
                {
                    timer -= Time.deltaTime;
                }
                
                if (updown)
                {
                    transform.Rotate(Vector3.forward, -(rotateSpeed * Time.deltaTime));
                }
                else
                {
                    transform.Rotate(Vector3.forward, (rotateSpeed * Time.deltaTime));
                }
            }
        }
    }
}
