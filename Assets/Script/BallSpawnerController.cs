using UnityEngine;


public class BallSpawnerController : MonoBehaviour
{

    public GameObject Projectile;
    public int Force = 50;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject Ball = Instantiate(Projectile, transform.position, Quaternion.identity) as GameObject;
            Ball.GetComponent<Rigidbody>().velocity = transform.forward * Force;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}