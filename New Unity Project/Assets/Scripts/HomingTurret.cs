using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingTurret : MonoBehaviour
{
    [SerializeField] Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.position;
        Vector2 homingAt = player.position - transform.position;

        float angle = Mathf.Atan2(homingAt.x, homingAt.y) * Mathf.Rad2Deg - 90f;
        Quaternion rotates = Quaternion.Euler(0, 0, -angle -90);
        transform.rotation = rotates;
    }
}
