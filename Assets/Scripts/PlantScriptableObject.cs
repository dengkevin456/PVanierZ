using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlantScriptableObject", menuName = "PlantScriptableObject", order = 0)]
public class PlantScriptableObject : ScriptableObject
{
    public string id;
    public string name;
    public int cost;
    public Sprite sprite;
    public GameObject plantPrefab;


    [ContextMenu("Generate GUID")]
    private void GenerateGUID()
    {
        id = System.Guid.NewGuid().ToString();
    }
}