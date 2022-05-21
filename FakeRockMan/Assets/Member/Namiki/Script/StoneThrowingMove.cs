using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneThrowingMove : MonoBehaviour
{
    // êŒÇÃë¨ìx
    [SerializeField]
    float speed = 100f;
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

            localPosition.x = Mathf.Clamp(localPosition.x -= speed * Time.deltaTime, -1060, 1060f);

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
