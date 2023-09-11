using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLight : MonoBehaviour
{
    [SerializeField] public Texture image;
    void OnGUI()
	{
		GUI.DrawTexture(new Rect(0 ,0 ,Screen.width * 2 , Screen.height), image);
	}
}
