using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldThrowingMove : MonoBehaviour
{
    // ã‡ÇÃë¨ìx
    [SerializeField]
    float verticalSpeed = 100f;
    [SerializeField]
    float horizontalSpeed = 100f;
    void Start()
    {
        StartCoroutine("Stonethrowing");
    }

    // Update is called once per frame
    #region ìäù±
    IEnumerator Stonethrowing()
    {
        while (true)
        {
            var RockTransform = GetComponent<RectTransform>();
            var localPosition = RockTransform.localPosition;

            localPosition.x = Mathf.Clamp(localPosition.x -= horizontalSpeed * Time.deltaTime, -1060, 1060f);

            localPosition.y = Mathf.Clamp(localPosition.y += verticalSpeed * Time.deltaTime, -400, 400);

            RockTransform.localPosition = localPosition;

            if (RockTransform.localPosition.x <= -1060f)
            {
                Destroy(this.gameObject);
            }
            yield return null;
        }
    }
    #endregion
}
