using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody rb;
    private GameObject player;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        rb.AddForce(direction * speed);
    }
}
