using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileRock : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private int count = 0;
    [SerializeField, Header("ÉuÉçÉbÉNHP")]
    private int RockHP = 2;
    [SerializeField, Header("âÊëú")]
    private Sprite sprite1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dame")
        {
            RockHP--;
           // spriteRenderer.sprite = sprite1; ;
            count++;
            if (RockHP == 0)
            {
                StartCoroutine("Hp");
            }
            collision.gameObject.SetActive(false);
        }
        
    }
    public IEnumerator Hp()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
    }



}
