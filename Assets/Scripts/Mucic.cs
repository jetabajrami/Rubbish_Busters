using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mucic : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
