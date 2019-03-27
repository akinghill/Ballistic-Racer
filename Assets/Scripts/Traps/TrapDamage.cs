﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour {
	public bool rotate;
    void Update()
    {
		if (rotate) {
			transform.Rotate (0, (Time.deltaTime * 180), 0);
		}
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent.tag == "Ship")
        {
			other.gameObject.GetComponentInParent<PlayerHealth>().Death();
        }
    }
}
