﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	public GameObject FinishText;
	// public GameObject MilliDisplay;
	// public GameObject MilliDisplay;

	void OnTriggerEnter()
	{
		if (LapTimeManager.SecondCount <= 9)
		{
			SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
		}
		else
		{
			SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
		}

		if (LapTimeManager.MinuteCount <= 9)
		{
			MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
		}
		else
		{
			MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
		}

		MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliDisplay;

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;

		HalfLapTrig.SetActive(true);
		LapCompleteTrig.SetActive(false);


		FinishText.GetComponent<Text>().text = "FINISH";
		FinishText.SetActive(true);


	}

}
