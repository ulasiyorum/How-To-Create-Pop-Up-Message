using TMPro;
using UnityEngine;

public static class StartPopUpMessage
{
    public static void Message(string message, Color messageColor)
    {
        GameObject go = GameObject.Instantiate(AssetManager.Instance.prefab,AssetManager.Instance.canvas);

        go.GetComponent<TMP_Text>().text = message;
        go.GetComponent<TMP_Text>().color = messageColor;
    }
}
