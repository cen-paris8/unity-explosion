﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Light>().range = Mathf.Lerp(GetComponent<Light>().range, 0, Time.deltaTime);
    }
}
