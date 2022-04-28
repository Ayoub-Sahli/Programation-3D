using UnityEngine;

public class ControlTarget : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigid;
    public GameObject target;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Collision");
        Destroy(this.gameObject);
        Instantiate(target, new Vector3(Random.Range(-50, 50), 5, Random.Range(-50, 50)), Quaternion.identity);
        Instantiate(target, new Vector3(Random.Range(-50, 50), 5, Random.Range(-50, 50)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
