using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    public GameObject cubeGameObject;
    private Vector3 offset = new Vector3(0, 11.6f, -20f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cubeGameObject.transform.position + offset;
    }
}
