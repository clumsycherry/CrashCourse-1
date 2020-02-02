using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class retain_object_on_load : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("phone");
        DontDestroyOnLoad(this.gameObject);
    }
}