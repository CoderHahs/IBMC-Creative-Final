﻿#pragma strict

var X : float;

function Start () {
	X = transform.localScale.x;
}

function Update () {
 	if(Input.GetKey (KeyCode.LeftArrow)) {
 	transform.localScale.x = X;
 	}
 	else if (Input.GetKey (KeyCode.RightArrow)) {
 	transform.localScale.x = -X;
 	}
}