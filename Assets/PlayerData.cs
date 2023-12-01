using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int life = 5;
    public int maxLife = 5;

    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    public void Load()
    {
        life = PlayerPrefs.GetInt("life");
        coins = PlayerPrefs.GetInt("coins");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("life", life);
        PlayerPrefs.SetInt("coins", coins);
    }
}

[CreateAssetMenu(fileName = "new SO", menuName = "UFT/Create SO")]
public class CardSO : ScriptableObject
{
    public string cardName;
    public int cardCost;
    public int cardAttack;
    public int cardHealth;
    public Sprite cardSprite;
}