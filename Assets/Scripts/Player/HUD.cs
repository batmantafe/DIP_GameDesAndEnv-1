using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public float playerFuelMax;
    public static float playerFuel;
    public GUIStyle FuelBarStyle; // Player > HUD > FuelBarRed > Normal > Background
    public GUIStyle fuelBarBackStyle;

    public GameObject exhaust, topRocket, botRocket, leftRocket, rightRocket;

    public GUIStyle FuelBarFont;
    private Color fontPink;

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
        GUI.Box(new Rect(5.9f * scrW, 8.3f * scrH, 4.2f * scrW, 0.7f * scrH), "", fuelBarBackStyle); //
        GUI.Box(new Rect(6f * scrW, 8.4f * scrH, playerFuel * (4 * scrW) / playerFuelMax, 0.5f * scrH), "", FuelBarStyle);

        // "Fuel" Text
        fontPink = new Color(255,174,201);
        FuelBarFont.normal.textColor = fontPink;
        FuelBarFont.fontSize = 20;

        if (playerFuel > 0)
        {
            GUI.Label(new Rect(6.9f * scrW, 8.45f * scrH, 2 * scrW, 0.5f * scrH), "FUEL", FuelBarFont);
        }

        // "Low" Text
        if (playerFuel <= 33 && playerFuel > 0)
        {
            GUI.Label(new Rect(6.9f * scrW, 8.65f * scrH, 2 * scrW, 0.5f * scrH), "LOW", FuelBarFont);
        }

        if (playerFuel <= 0)
        {
            GUI.Label(new Rect(6.9f * scrW, 8.55f * scrH, 2 * scrW, 0.5f * scrH), "NO FUEL", FuelBarFont);
        }
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

            exhaust.SetActive(false);

            topRocket.SetActive(false);
            botRocket.SetActive(false);
            rightRocket.SetActive(false);
            leftRocket.SetActive(false);
        }

        if (playerFuel > 0)
        {
            exhaust.SetActive(true);

            topRocket.SetActive(true);
            botRocket.SetActive(true);
            rightRocket.SetActive(true);
            leftRocket.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            playerFuel = playerFuel + 20f;
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            playerFuel = playerFuel - 20f;
        }
    }
}
