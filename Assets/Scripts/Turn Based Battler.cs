using System;
using System.Collections;
using UnityEngine;

public class TurnBasedBattler : MonoBehaviour
{
    public AnimationCurve scaleCurve;
    public float duration;
    private Coroutine scaleShape;
    private bool interactableVariable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator ScaleShape()
    {
        float progress = 0f;
  
        while (progress < duration)
        {
            progress += Time.deltaTime;
            transform.localScale = scaleCurve.Evaluate(progress / duration) * Vector3.one;
            yield return null;
        }
    }

    public void OnClick()
    {
        scaleShape = StartCoroutine(ScaleShape());
    }
}
