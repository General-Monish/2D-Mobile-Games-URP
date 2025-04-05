using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] levelManager levelManager;

    Rigidbody2D rb;

    float horizontalInput;
    float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void GetInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer()
    {
        /*Vector3 moveDir = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 moveDelta =  moveDir.normalized * speed * Time.deltaTime;
        transform.position += moveDelta;*/
        Vector2 newVelocity = new Vector2 (horizontalInput, verticalInput).normalized *speed;
        rb.velocity = newVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obs"))
        {
            PlayerDie();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("finish"))
        {
            LevelComplete();
        }
    }

    void PlayerDie()
    {
        levelManager.OnPlayerDeath();
        Destroy(gameObject);
    }

    void LevelComplete()
    {
        Debug.Log("Level Finished");
        levelManager.OnLevelComplete();
    }
}
