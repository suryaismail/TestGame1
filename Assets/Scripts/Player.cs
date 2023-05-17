using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float top = 10;
    public static float bottom = 10;
    public static float left = 10;
    public static float right = 10;

    // Start is called before the first frame update
    void Start()
    {
        //GetAllPrefabs();
        GameObject spritePrefab = (GameObject)Resources.Load("Prefabs/MovingSprite", typeof(GameObject));
        //spritePrefab = (GameObject)Resources.Load("MovingSprite");

        Debug.Log(spritePrefab);
        Instantiate(spritePrefab, new Vector2(0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetAllPrefabs()
    {
        string[] foldersToSearch = { "Assets" };
        List<GameObject> allPrefabs = GetAssets<GameObject>(foldersToSearch, "t:prefab");
    }

    public static List<T> GetAssets<T>(string[] _foldersToSearch, string _filter) where T : UnityEngine.Object
    {
        string[] guids = AssetDatabase.FindAssets(_filter, _foldersToSearch);
        List<T> a = new List<T>();
        for (int i = 0; i < guids.Length; i++)
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[i]);
            a.Add(AssetDatabase.LoadAssetAtPath<T>(path));
        }
        return a;
    }
}
