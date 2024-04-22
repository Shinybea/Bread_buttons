using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseLevel : MonoBehaviour
{
    public static ChooseLevel Instance;
    public int Level;

    private void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Level1()
    {
        Level = 1;
        Debug.Log($"Level set to {Level}");

    }
    public void Level2()
    {
        Level = 2;
        Debug.Log($"Level set to {Level}");
    }
}
