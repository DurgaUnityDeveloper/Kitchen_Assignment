using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDemoWalk : MonoBehaviour
{

    Rigidbody rb;
    public float xVal;
    public float yVal;
    public float zVal;
    float walkingSpeed = 1;
    public Vector3 vectorValue;
    public Animator demoWalkAnim;
    bool isWalking;

    public float XRot = 0;
    public float YRot = 0;
    public float ZRot = 0;

    public GameObject gameObj;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        gameObj = GetComponent<GameObject>();
       demoWalkAnim = GetComponent<Animator>();
       vectorValue = new Vector3(xVal, yVal, zVal);
    }

    // Update is called once per frame
    void Update()
    {
       
       print("hi");
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {                
                transform.localRotation = Quaternion.Euler(0, -90, 0);
                demoWalkAnim.SetInteger("action", 1);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                xVal = xVal - 0.005f;
                transform.position = new Vector3(xVal, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                demoWalkAnim.SetInteger("action", 0);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.localRotation = Quaternion.Euler(0, 90, 0);
                demoWalkAnim.SetInteger("action", 1);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                xVal = xVal + 0.005f;
                transform.position = new Vector3(xVal, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                demoWalkAnim.SetInteger("action", 0);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.localRotation = Quaternion.Euler(0, -2, 0);
                demoWalkAnim.SetInteger("action", 1);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                zVal = zVal + 0.005f;
                transform.position = new Vector3(transform.position.x, transform.position.y, zVal);
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                demoWalkAnim.SetInteger("action", 0);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                demoWalkAnim.SetInteger("action", 1);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                zVal = zVal - 0.005f;
                transform.position = new Vector3(transform.position.x, transform.position.y, zVal);
            }

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                demoWalkAnim.SetInteger("action", 0);
            }
        }

}
