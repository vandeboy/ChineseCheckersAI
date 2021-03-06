using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
	public GameObject button;

	//public bool isManager=false;

	public string toggleText;
	public bool rotate = true;
	public bool target = false;
	public bool sfx = true;
	public int speed = 0;

	/*public static void Start(){
		GameObject.Find ("Main Screen").gameObject.SetActive (true);
		GameObject.Find ("Settings Screen").gameObject.SetActive (false);
		GameObject.Find ("Mode Select Screen").gameObject.SetActive (false);
		GameObject.Find ("Credits Screen").gameObject.SetActive (false);
	}*/

	public void setGameMode(string gameMode){
		PlayerPrefs.SetString ("Mode", gameMode);
	}

	public void toggleCamera(){
		rotate = !rotate;
		if (rotate) {
			PlayerPrefs.SetInt ("CamRotate", 1);
			toggleText="On";
			Debug.Log("Rotate is ON");
			//rotate = false;
		} else {
			PlayerPrefs.SetInt ("CamRotate", 0);
			toggleText = "Off";
			Debug.Log("Rotate is OFF");
			//rotate = true;
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}

	public void toggleTarget(){
		target = !target;
		if (target) {
			PlayerPrefs.SetInt ("Target", 1);
			toggleText="On";
			Debug.Log("Target is ON");
		} else {
			PlayerPrefs.SetInt ("Target", 0);
			toggleText = "Off";
			Debug.Log("Target is OFF");
			// = true;
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}

	public void toggleSFX(){
		sfx = !sfx;
		if (sfx) {
			PlayerPrefs.SetInt ("SFX", 1);
			toggleText="On";
			Debug.Log("SFX are ON");
		} else {
			PlayerPrefs.SetInt ("SFX", 0);
			toggleText = "Off";
			Debug.Log("SFX are OFF");
		}

		button.GetComponentInChildren<Text>().text = toggleText;

	}

	public void toggleAISpeed(){
		speed=(speed+1)%3;
		if (speed == 0) {
			PlayerPrefs.SetInt ("Speed", 0);
			toggleText = "Slow";
			Debug.Log ("AI Speed: slow");
		} else if (speed == 1) {
			PlayerPrefs.SetInt ("Speed", 1);
			toggleText = "Med";
			Debug.Log ("AI Speed: med");
		} else {
			PlayerPrefs.SetInt ("Speed", 2);
			toggleText = "Fast";
			Debug.Log ("AI Speed: fast");
		}
		button.GetComponentInChildren<Text>().text = toggleText;

	}


}
