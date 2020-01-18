//LAP COMPLETE SCRIPT

using UnityEngine;	
using UnityEngine.UI;
using System;

public class LapComplete : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;
	
	public static int bestMinute;
	public static int bestSecond;
	public static float bestMilli;
	
	public GameObject LapCounter;
	public int LapsDone;

	public float RawTime;
	
	public GameObject RaceFinish;

	void Update() {
		if (LapsDone == 2) {
			RaceFinish.SetActive(true);
		}
	}
	
	void OnTriggerEnter () {
		LapsDone += 1;
		
		RawTime = PlayerPrefs.GetFloat("RawTime");
		
		LapCounter.GetComponent<Text> ().text = "" + LapsDone;
		
		
		/*if (LapTimeManager.MinuteCount > bestMinute ||
			(LapTimeManager.MinuteCount == bestMinute
				&& LapTimeManager.SecondCount > bestSecond) ||
			(LapTimeManager.SecondCount == bestSecond
				&& LapTimeManager.MilliCount > bestMilli)) {
					LapTimeManager.MinuteCount = 0;
					LapTimeManager.SecondCount = 0;
					LapTimeManager.MilliCount = 0;

					HalfLapTrig.SetActive (true);
					LapCompleteTrig.SetActive (false);
					return;
				}*/
				
		if (LapTimeManager.RawTime <= RawTime) {
			if (LapTimeManager.MinuteCount <= 9) {
				MinuteDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.MinuteCount + ".";
			} else {
				MinuteDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MinuteCount + ".";
			}

			if (LapTimeManager.SecondCount <= 9) {
				SecondDisplay.GetComponent<Text> ().text = "0" + LapTimeManager.SecondCount + ".";
			} else {
				SecondDisplay.GetComponent<Text> ().text = "" + LapTimeManager.SecondCount + ".";
			}
			
			MilliDisplay.GetComponent<Text> ().text = "" + LapTimeManager.MilliCount;
		}
		

		bestMinute = LapTimeManager.MinuteCount;
		bestSecond = LapTimeManager.SecondCount;
		bestMilli = LapTimeManager.MilliCount;
		
		PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
		PlayerPrefs.SetInt("SecondSave", LapTimeManager.SecondCount);
		PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
		PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);
		
		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		LapTimeManager.RawTime = 0;
		HalfLapTrig.SetActive (true);
		LapCompleteTrig.SetActive (false);
	}

}