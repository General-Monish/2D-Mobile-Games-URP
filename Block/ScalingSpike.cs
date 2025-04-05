using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingSpike : MonoBehaviour
{
    [SerializeField] float minScale;
    [SerializeField] float scaleDelay;
    bool isWaiting = false;
    float timer = 0;
    [SerializeField] float maxScale;
    [SerializeField] float scalingFactor; //  Direction of scale change (positive = grow, negative = shrink).
    [SerializeField] float scalingSpeed;
    private float currentScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWaiting)
        {
            HandleWaiting();
        }
        else
        {
            ScaleSpikeBall();
        }
        
    }

    private void ScaleSpikeBall()
    {
        currentScale += scalingFactor * scalingSpeed * Time.deltaTime;  // Adjust the scale
        currentScale = Mathf.Clamp(currentScale, minScale, maxScale);   // Keep the scale within boundaries

        if (currentScale == maxScale || currentScale == minScale)  // If the spike reaches its limits
        {
            isWaiting = true;
            scalingFactor = -scalingFactor;  // Reverse the scaling direction
        }

        ApplyCurrentScale();  // Apply the updated scale to the spike
    }
    private void ApplyCurrentScale()
    {
        transform.localScale = new Vector3(currentScale, currentScale, 1);  // Update the spike's size
    }

    void HandleWaiting()
    {
        timer += Time.deltaTime;
        if(timer >= scaleDelay)
        {
            isWaiting = false;
            timer = 0f;
        }
    }
}
