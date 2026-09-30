using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    private int scoreValue = 0;
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
        // Move the player up when the W or Up Arrow key is pressed
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }   
        // Move the player down when the S or Down Arrow key is pressed
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }   
        // Move the player right when the D or Right Arrow key is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }   
        // Move the player left when the A or Left Arrow key is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }   

        //4.25 up and down and 5.25 left and right.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.25f, -5.25f), Mathf.Clamp(transform.position.y, -4.25f, 4.25f), transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "projectile")
        {
            if(collision.GetComponent<ProjectileMove>() != null)
            {
                scoreValue += collision.GetComponent<ProjectileMove>().points;
                scoreText.text = "Score: " + scoreValue;
            }
            Destroy(collision.gameObject);
        }
    }
}
