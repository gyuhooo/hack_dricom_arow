using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class Ship : ScriptableObject
{
	public List<ShipEntity> Sheet1; // Replace 'EntityType' to an actual type that is serializable.
}
