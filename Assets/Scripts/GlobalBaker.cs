﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue = 20;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.cashCount;

        bakerStats.GetComponent<Text>().text = "Bakers: " +  numberOfBakers + " @ " + bakePerSec + "Per Second";

        fakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        realText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;

        if (currentCash >= bakerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
            turnOffButton = false;
        }
    }
}
