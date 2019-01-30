﻿using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    public AudioClip collect;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SceneManager.Instance.SetCountText(count);
    }

    //Update Physics effect before per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            SoundManager.Instance.PlaySound(collect,7.0f,8.0f);
            other.gameObject.SetActive(false);
            ++count;
            SceneManager.Instance.SetCountText(count);
        }
    }
}
