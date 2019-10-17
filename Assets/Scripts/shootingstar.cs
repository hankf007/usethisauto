using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingstar : MonoBehaviour
{
    SpriteRenderer rend;

    public float x1;
    public float x2;
    public float y;
    public float z1;
    public float z2;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;


        StartCoroutine("InOut");


        var rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (Random.Range(x1,x2),y,Random.Range(z1,z2));

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator InOut()
    {
        StartCoroutine("FadeIn");
        yield return new WaitForSeconds(1f);
        StartCoroutine("FadeOut");
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

    IEnumerator FadeIn()
    {
        for (float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);

        }
    }


    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);

        }
    }



}
