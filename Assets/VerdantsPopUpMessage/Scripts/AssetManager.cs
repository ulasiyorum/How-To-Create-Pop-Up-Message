using System.Collections;
using System.Collections.Generic;
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
}
