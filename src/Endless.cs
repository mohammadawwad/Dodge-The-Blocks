
using UnityEngine;

public class Endless : MonoBehaviour
{
    public Rigidbody floor;
    public float forwardforce = 200f;
    // Update is called once per frame
    void Update()
    {
        floor.AddForce(0, 0, forwardforce * Time.deltaTime);
    }
}
