using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteController : MonoBehaviour {
	public SpriteManager spriteManager;
	public GameObject objectPrefab;
	private ArrayList objects = new ArrayList();
	
	void Start () {
		objects.Add(Instantiate(objectPrefab, new Vector3(0, 10, 0), Quaternion.identity));
		spriteManager.AddSprite((GameObject)objects[0], 1f, 1f, 0,0, 150,150,false);
	}

}
