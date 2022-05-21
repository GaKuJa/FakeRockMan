using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneEnemyMove : MonoBehaviour
{
    // “G‚Ì‘¬“x
    [SerializeField]
    private float speed = 100f;
    void Start()
    {
        StartCoroutine("Move");
    }

    #region ˆÚ“®
    IEnumerator Move()
    {
        while (true)
        {
            var RockTransform = GetComponent<RectTransform>();
            var localPosition = RockTransform.localPosition;

            localPosition.y = Mathf.Clamp(localPosition.y -= speed * Time.deltaTime, -420, 420);

            RockTransform.localPosition = localPosition;

            if (Mathf.Abs(localPosition.y) > 390)
            {
                speed *= -1;
            }

            yield return null;
        }
    }
    #endregion
}
