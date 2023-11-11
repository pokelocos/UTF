using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    public Image healBackground;
    public Text healthText;

    private CharacterStatus status;

    // Start is called before the first frame update
    void Start()
    {
        status = FindObjectOfType<CharacterStatus>();
    }

    // Update is called once per frame
    void Update()
    {
        Actualize(status.coins, status.maxHealth);    
    }

    public void Actualize(int value, int maxValue)
    {
        healthText.text = value.ToString();

        healBackground.fillAmount = (float)value / maxValue;
    }

}
