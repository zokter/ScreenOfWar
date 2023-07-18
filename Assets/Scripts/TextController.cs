using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;

    public void SetText(string text)
    {
        textMeshProUGUI.text = text;
    }

    public void DisableText()
    {
        textMeshProUGUI.enabled = false;
    }

    public void EnableText()
    {
        textMeshProUGUI.enabled = true;
    }
}
