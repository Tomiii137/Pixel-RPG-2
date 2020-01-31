using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    float currentLifepoints;
    float maxLifepoints;
    public Image healthBarImage;
    public Text ratioText;
    void Start()
    {
        maxLifepoints = GetComponent<HealthManager>().getMaxHealth();
        updateLifeBar();
    }

    private void updateLifeBar()
    {
        currentLifepoints = GetComponent<HealthManager>().currentHealth;

        float ratio = currentLifepoints / maxLifepoints;
        if (currentLifepoints>= 0)
        {
            healthBarImage.rectTransform.localScale = new Vector3(ratio, 1, 1);
            ratioText.text = currentLifepoints.ToString() + '/' + maxLifepoints.ToString();
        }

    }

    void Update()
    {
        updateLifeBar();
    }

}
