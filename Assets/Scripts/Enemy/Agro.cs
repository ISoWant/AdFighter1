﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agro : MonoBehaviour
{
	private Enemy parent;
	private void Start() {
		parent = GetComponentInParent<Enemy> ();
    }

	private void OnTriggerEnter2D(Collider2D collision) {
		if( collision.tag == "Player" ) {
			parent.Target = collision.transform;
		}
	}
}
