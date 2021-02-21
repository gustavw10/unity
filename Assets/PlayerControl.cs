using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 10;
    public float points = 0;
    public float life = 3;
    private Rigidbody rb;
    bool isgrounded = true;
    public bool hasFlight = false;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (isgrounded && hasFlight)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Vector3 jump = new Vector3(0.0f, 200, 0.0f);
                GetComponent<Rigidbody>().AddForce(jump);
            }
        }
        if (isgrounded) { 
        rb.AddForce(movement * speed);
        }
        else
        {
            rb.AddForce(movement * 7);
        }

        if (life < 0)
        {
            // Die - respawn to start  
        }

    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor")
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Floor")
        {
            isgrounded = false;
        }
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.black;
        GUI.Label(new Rect(10, 10, 400, 20), "Score : " + points + "/9      Life : " + life, style);
    }
}
