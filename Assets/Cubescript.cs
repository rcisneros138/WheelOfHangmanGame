using UnityEngine;
using System.Collections;

//BFT TODO: Rename this class
public class Cubescript : MonoBehaviour
{
    public AnimationCurve animationCurve;

    private bool spinning;

	// Use this for initialization
	void Start ()
    {
        spinning = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(1) && !spinning)
        {
            StartCoroutine(DoSpin(10.0f, Random.Range(2000, 3000)));
        }
        
        
        }
    public IEnumerator DoSpin(float time, float angle)
    {
        spinning = true; float timer = 0;
        float StartAngle = transform.eulerAngles.z;
        while (timer < time)
        {
            float endAngle = animationCurve.Evaluate(timer / time) * angle;
            transform.eulerAngles = new Vector3(0.0f, 0.0f, (endAngle+StartAngle));
            timer += Time.deltaTime;
            yield return 0;
        }
        spinning = false;
    }
}
