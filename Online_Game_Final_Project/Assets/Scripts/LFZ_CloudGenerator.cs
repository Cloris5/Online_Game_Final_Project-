using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFZ_CloudGenerator : MonoBehaviour
{
    public GameObject platform;
    Vector3 pos;
    public static LFZ_CloudGenerator instance;


    // Start is called before the first frame update
    void Start()
    {
        pos = platform.transform.position;

        //随机

        InvokeRepeating("SpawnPlatform", 1f, 7f);

    }


    void SpawnPlatform()
    {
        Instantiate(platform, pos, Quaternion.identity);
    }


}