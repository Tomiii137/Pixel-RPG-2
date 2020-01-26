using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField] float currentLifepoints;
    [SerializeField] float maxLifepoints;
    public Image healthBarImage;
    public Text ratioText;
    void Start()
    {
        updateLifeBar();
    }

    private void updateLifeBar()
    {
        float ratio = currentLifepoints / maxLifepoints;
        healthBarImage.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = currentLifepoints.ToString() + '/' + maxLifepoints.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            getDamage(collision.gameObject);
        }
    }
    private void getDamage(GameObject _bullet)
    {
        Bullet hit = _bullet.GetComponent<Bullet>();
        currentLifepoints -= hit.bulletDamage;
    }
    void Update()
    {
        updateLifeBar();
    }

}
