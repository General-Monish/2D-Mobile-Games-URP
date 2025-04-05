using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        MovePlayer();
    }

    void GetInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        Vector3 moveDir = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 moveDelta =  moveDir.normalized * speed * Time.deltaTime;
        transform.position += moveDelta;
    }
}
