using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public float playerFuelMax;
    public static float playerFuel;
    public GUIStyle FuelBarRed; // Player > HUD > FuelBarRed > Normal > Background

    // Use this for initialization
    void Start()
    {
        playerFuelMax = 100;
        playerFuel = 100;
    }

    // Update is called once per frame
    void Update()
    {
        FuelCheck();
    }

    void OnGUI()
    {

        float scrW = Screen.width / 16; // Dividing Screen Width into 16 parts, value of scrW = 1
        float scrH = Screen.height / 9; // Dividing Screen Height into 9 parts, value of scrH = 1

        // Health Bar
        GUI.Box(new Rect(6f * scrW, 8.4f * scrH, 4 * scrW, 0.5f * scrH), ""); //
        GUI.Box(new Rect(6f * scrW, 8.4f * scrH, playerFuel * (4 * scrW) / playerFuelMax, 0.5f * scrH), "FUEL", FuelBarRed);
    }

    void FuelCheck()
    {
        if (playerFuel >= playerFuelMax)
        {
            playerFuel = playerFuelMax;
        }

        if (playerFuel <= 0)
        {
            playerFuel = 0;
        }
    }
}
