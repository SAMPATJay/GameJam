using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed;

    public bool isColliding;

    public GameObject bomb;

    public GameObject pointer;

    private float moveHor, moveVer, lastVer, lastHor, angle;

    Transform pointerPivot;
    Rigidbody rb;

    void Start()
    {
        pointerPivot = gameObject.GetComponentInChildren<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
        bombDrop();
    }

    void move()
    {
        moveHor = Input.GetAxisRaw("Horizontal");
        moveVer = Input.GetAxisRaw("Vertical");
        if (moveVer != 0 || moveHor != 0)
        {
            lastVer = Mathf.Round(moveVer);
            lastHor = Mathf.Round(moveHor);
        }
        angle = Mathf.Atan2(lastHor, lastVer) * Mathf.Rad2Deg;
        pointerPivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.up);
        rb.velocity = new Vector3(movementSpeed * moveHor,0, movementSpeed * moveVer);
        //transform.position = new Vector3(transform.position.x + (moveHor * (movementSpeed) * Time.deltaTime), transform.position.y, transform.position.z + (moveVer * (movementSpeed) * Time.deltaTime));
    }

    void bombDrop()
    {
        if (Input.GetButtonDown("Jump") && !isColliding)
        {
            Instantiate(bomb, pointer.transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Breakable" || other.gameObject.tag == "Unbreakable" || other.gameObject.tag == "Enemy")
        {
            isColliding = true;
        }
        else
        {
            isColliding = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Breakable" || other.gameObject.tag == "Unbreakable" || other.gameObject.tag == "Enemy")
        {
            isColliding = true;
        }
        else
        {
            isColliding = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Breakable" || other.gameObject.tag == "Unbreakable" || other.gameObject.tag == "Enemy")
        {
            isColliding = false;
        }
        else
        {
            isColliding = true;
        }
    }
}
