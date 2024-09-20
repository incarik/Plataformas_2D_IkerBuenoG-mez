using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    private Rigidbody2D characterRigidbody;
    [SerializeField]private float characterSpeed = 4.5f;
    private float horizontalInput;

    void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal"); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        characterRigidbody.velocity = new Vector2(horizontalInput  * characterSpeed, characterRigidbody.velocity.y) *characterSpeed;
    }
}   