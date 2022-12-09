using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cameraswitch : MonoBehaviour {
 
	public GameObject[] cameras;
	public string[] shotcuts;
	public bool changeAudioListener = true;
 
	void Update()
	{
		int i = 0;//declare a variable to store number of camera
		for(i=0; i<cameras.Length; i++)
		{
			if (Input.GetKeyUp(shotcuts[i]))
				SwitchCamera(i);//do swtch camera function
		}
	}
 
	void SwitchCamera(int index)
	{
		int i = 0;
		for (i=0; i<cameras.Length; i++)
		{
			if (i != index)//if not current camera ,switch to it return false value
			{
				if (changeAudioListener)
				{
					cameras[i].GetComponent<AudioListener>().enabled = false;
				}
				cameras[i].GetComponent<Camera>().enabled = false;
			}
			else
			{
				if (changeAudioListener)//if its current camera return true
				{
					cameras[i].GetComponent<AudioListener>().enabled = true;
				}
				cameras[i].GetComponent<Camera>().enabled = true;
			}
		}
	}
}