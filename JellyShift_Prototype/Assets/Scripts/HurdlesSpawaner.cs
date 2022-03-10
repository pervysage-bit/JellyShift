using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdlesSpawaner : MonoBehaviour
{
  
    public GameObject[] hurdles;
    public GameObject playerposition;
    int instatiatedObjects = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HurdlesSpawning", 1f, 2f);
    }
    void HurdlesSpawning()
    {
        int i = Random.RandomRange(0, hurdles.Length);

        Instantiate(hurdles[i], new Vector3(hurdles[i].transform.position.x, hurdles[i].transform.position.y, playerposition.transform.position.z + 20f), hurdles[i].transform.rotation);
        instatiatedObjects++;
    }
}
