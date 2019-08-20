﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCookie;
    public AudioSource playSound;

    public void StartAutoCookie()
    {
        playSound.Play();
        autoCookie.SetActive(true);
        GlobalCash.cashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;
    }
}
