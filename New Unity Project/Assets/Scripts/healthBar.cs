using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthBar : MonoBehaviour
{
    float currentLifepoints;
    float maxLifepoints;
    public GameObject healthBarImage;
    public TextMeshProUGUI ratioText;
    void Start()
    {
        maxLifepoints = GetComponent<HealthManager>().getMaxHealth();
        updateLifeBar();
    }

    private void updateLifeBar()
    {
        currentLifepoints = GetComponent<HealthManager>().currentHealth;

        float ratio = (currentLifepoints / maxLifepoints) * 1.675f;
        if (currentLifepoints>= 0)
        {
            healthBarImage.transform.localScale = new Vector3(ratio, 1, 1);
            ratioText.text = currentLifepoints.ToString() + '/' + maxLifepoints.ToString();
        }

    }

    void Update()
    {
        updateLifeBar();
    }

}
