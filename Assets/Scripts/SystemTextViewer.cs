using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum SystemType { Money = 0, Build }

public class SystemTextViewer : MonoBehaviour
{
    private TextMeshProUGUI textSystem;
    private TMPAlpha TMPAlpha;

    private void Awake()
    {
        textSystem = GetComponent<TextMeshProUGUI>();
        TMPAlpha = GetComponent<TMPAlpha>();
    }

    public void PrintText(SystemType type)
    {
        switch (type)
        {
            case SystemType.Money:
                textSystem.text = "System : Not Enough Money...";
                break;
            case SystemType.Build:
                textSystem.text = "System : Invalid Build Tower...";
                break;
        }

        TMPAlpha.FadeOut();
    }
}
