using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask zombieLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // move towards right
        rb.linearVelocity = new Vector3(speed, 0, 0) * Time.deltaTime;
    }

    void OnDestroy()
    {
        // play animation
        Debug.Log("Playing hit animation on " + gameObject.name);
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == zombieLayer)
        {
            //other.gameObject.GetComponent(<Zombie>).deal
            Debug.Log("Damage zombie");
            Destroy(gameObject, 0.5f);
        }
    }
}
