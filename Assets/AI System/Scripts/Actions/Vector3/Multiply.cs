﻿using UnityEngine;
using System.Collections;

namespace AISystem.Actions{
	[HideOwnerDefault]
	[Category("Vector3")]
	[System.Serializable]
	public class Multiply : BaseAction {
		[StoreParameter(true,typeof(Vector3Parameter))]
		public string store;
		public FloatParameter value;
		public Vector3Parameter vector;
		
		
		public override void OnEnter ()
		{
			owner.SetVector3 (store, owner.GetValue(vector)*owner.GetValue(value));
			Finish ();
		}
	}
}