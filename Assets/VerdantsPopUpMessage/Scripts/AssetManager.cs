using UnityEngine;

public class AssetManager : MonoBehaviour
{
    public static AssetManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public GameObject prefab;
    public Transform canvas;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartPopUpMessage.Message("This is a test!", Color.black);
        }
    }
}
