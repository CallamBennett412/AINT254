using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimator : MonoBehaviour {

    public int light;
    public GameObject flameLight;

	
	// Update is called once per frame
	void Update () {
		
        if (light == 0)
        {
            StartCoroutine(AnimateLight());

        }

	}

    IEnumerator AnimateLight()
    {
        light = Random.Range(1, 4);

        if (light == 1)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim01");
        }
        if (light == 2)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim02");
        }
        if (light == 3)
        {
            flameLight.GetComponent<Animation>().Play("TorchAnim03");
        }
        yield return new WaitForSeconds(0.99f);
        light = 0;
    }
}
