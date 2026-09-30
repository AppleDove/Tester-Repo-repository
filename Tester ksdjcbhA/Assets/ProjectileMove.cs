using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 6;
    public int points= 100;
    // Update is called once per frame
    void Update()
    {
         transform.Translate(-transform.right * speed * Time.deltaTime);
         if (transform.position.x < -10)
         {
             Destroy(gameObject);
         }
    }
    
}
