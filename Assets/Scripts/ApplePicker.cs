using UnityEngine;
using System.Collections;
using System.Collections.Generic;                                           // 1
public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketprefab;
    public int numBaskets = 3;
    public float basketBottomY = -14;
    public float basketSpacingY = 2f;
    void Start()
    {
        for (int i = 0; i < numBaskets; i++)
        {

        }
    }
    public void AppleDestroyed()
    {                                         
       
    }
    
    void Update()
    {

    }
}