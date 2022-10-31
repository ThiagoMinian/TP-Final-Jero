using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNPC : MonoBehaviour
{
    bool cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown)
        {
            StartCoroutine(waitForCooldown());
            transform.Translate(Vector3.down * Time.deltaTime * 0.5f);
        }

        else
        {
            StartCoroutine(waitForCooldonw2());
            transform.Translate(Vector3.up * Time.deltaTime * 0.5f);
        }
    }

    IEnumerator waitForCooldown() //Cooldown para esperar un segundo al sacarme vida
    {
        cooldown = true;
        yield return new WaitForSeconds(1);
        cooldown = false;
    }

    IEnumerator waitForCooldonw2() //Cooldown para esperar un segundo al sacarme vida
    {
        cooldown = false;
        yield return new WaitForSeconds(1);
        cooldown = true;
    }
}
