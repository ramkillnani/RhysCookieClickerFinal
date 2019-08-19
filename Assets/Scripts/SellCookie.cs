using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton()
    {
        GlobalCookies.cookieCount -= 1;
        GlobalCash.cashCount += 1;
    }
}
