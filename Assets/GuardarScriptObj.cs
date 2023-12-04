using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NEW TEST",menuName = "HOLA/MUNDO")]
public class GuardarScriptObj : ScriptableObject
{
    public float life = 10.0f;
    public float damege = 10.0f;
    public float speed = 10.0f;

    public void Start()
    {

    }
}
