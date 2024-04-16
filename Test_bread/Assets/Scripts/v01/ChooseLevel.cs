using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChooseLevel : MonoBehaviour
{
    public int Level;

   public void Level1()
    {
        Level = 1;
        Debug.Log("Level1 Chosen");

    }
    public void Level2()
    {
        Level = 2;
        Debug.Log("Level2 Chosen");
    }
}
