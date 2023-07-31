using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrQuadrado : MonoBehaviour
{
    Rigidbody2D rbQuadrado;
    public float horizontal;
    public float vertical;
    public float velocidade = 10.0f;

    void Start()
    {
        rbQuadrado = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rbQuadrado.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        transform.position += new Vector3(0.1f, 0, 0);
    //        if (Input.GetKey(KeyCode.UpArrow))
    //        {
    //            transform.position += new Vector3(0.1f, 0.1f, 0);
    //        }
    //        if (Input.GetKey(KeyCode.DownArrow))
    //        {
    //            transform.position += new Vector3(0.1f, -0.1f, 0);
    //        }

    //    }
    //
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.position += new Vector3(-0.1f, 0, 0);
    //        if (Input.GetKey(KeyCode.UpArrow))
    //        {
    //            transform.position += new Vector3(-0.1f, 0.1f, 0);
    //        }
    //        if (Input.GetKey(KeyCode.DownArrow))
    //        {
    //            transform.position += new Vector3(-0.1f, -0.1f, 0);
    //        }
    //    }
    //
    //    if (Input.GetKey(KeyCode.UpArrow))
    //    {
    //        transform.position += new Vector3(0, 0.1f, 0);
    //    }
    //
    //   if (Input.GetKey(KeyCode.DownArrow))
    //    {
    //        transform.position += new Vector3(0, -0.1f, 0);
    //    }
    //

    //}
}
