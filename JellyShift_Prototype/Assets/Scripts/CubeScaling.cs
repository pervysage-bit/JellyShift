using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScaling : MonoBehaviour
{

    private Rigidbody cubeRb;
    public float speed = 50f;
    public float backSpeed = 50f;
    private Vector3 tempScale;
    private ParticleSystem cubeParticles;

    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        cubeParticles.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
       CubeScalingXY();
       CubePhysics();

    }
    void CubeScalingXY()
    {
            if (Input.GetKey(KeyCode.W) && transform.localScale.y <= 3)
            {
                tempScale = transform.localScale;
                tempScale.y += 0.1f;
                tempScale.x -= 0.1f;
                transform.localScale = tempScale;
            }
            if (Input.GetKey(KeyCode.S) && transform.localScale.x <= 3)
            {
                tempScale = transform.localScale;
                tempScale.y -= 0.1f;
                tempScale.x += 0.1f;
                transform.localScale = tempScale;
            }
        }

    void CubePhysics()
    {
        cubeRb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hurdles"))
        {
            cubeRb.AddForce(Vector3.back * backSpeed * Time.deltaTime, ForceMode.Impulse);
            Debug.Log("collided with hurdle");
        }
    }
}
