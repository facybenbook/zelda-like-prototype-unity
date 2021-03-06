﻿using UnityEngine;
using System.Collections;

namespace AISystem{
	[System.Serializable]
	public class StringParameter : NamedParameter {
		[SerializeField]
		private string value;
		
		public string Value
		{
			get{
				return this.value;
			}
			set{
				this.value = value;
			}
		}
	}
}