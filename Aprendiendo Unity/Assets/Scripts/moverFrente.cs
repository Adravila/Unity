﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Script utilizado para la Escena 3 (cámara) */

public class moverFrente : MonoBehaviour {
	
	public GameObject Player;
	private Vector3 distancia;

	// Use this for initialization
	void Start () {
		distancia = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = distancia + Player.transform.position;
	}
}
