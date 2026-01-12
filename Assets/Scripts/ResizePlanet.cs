using UnityEngine;

// Resizes a target uniformly via two button-callable methods: ScaleUp and ScaleDown
public class ResizePlanet : MonoBehaviour
{
    [Header("Target to scale (defaults to this)")]
    public GameObject target;

    [Header("Scaling step")]
    [Range(0.01f, 1f)]
    public float percentPerClick = 0.05f; // 5% per click

    [Header("Clamp uniform scale range")]
    public float minScale = 0.000186563f;
    public float maxScale = 0.000886563f;

    [Header("Animation")]
    [Tooltip("Time it takes to complete a scale step in seconds")]
    public float scaleDuration = 0.5f;
    [Tooltip("Easing curve for the scale animation (0..1 time -> 0..1 interpolation)")]
    public AnimationCurve ease = AnimationCurve.Linear(0, 0, 1, 1);

    Transform T => target != null ? target.transform : transform;

    Coroutine scaleRoutine;

    // Call from a UI Button named "Scale Up"
    public void ScaleUp()
    {
        float factor = 1f + Mathf.Max(0.01f, percentPerClick);
        ApplyUniformScaleFactorAnimated(factor);
    }

    // Call from a UI Button named "Scale Down"
    public void ScaleDown()
    {
        float decrease = Mathf.Clamp01(percentPerClick);
        float factor = Mathf.Max(0.0001f, 1f - decrease);
        ApplyUniformScaleFactorAnimated(factor);
    }

    // Uniformly scales while respecting min/max bounds based on the mean scale, animated over time
    void ApplyUniformScaleFactorAnimated(float factor)
    {
        var current = T.localScale;
        float mean = (current.x + current.y + current.z) / 3f;
        if (mean <= 0f) mean = 1f;

        float targetMean = Mathf.Clamp(mean * factor, minScale, maxScale);
        float finalFactor = targetMean / mean;
        Vector3 targetScale = current * finalFactor;

        // If duration is zero or extremely small, snap immediately
        if (scaleDuration <= 0.0001f)
        {
            if (scaleRoutine != null) { StopCoroutine(scaleRoutine); scaleRoutine = null; }
            T.localScale = targetScale;
            return;
        }

        // Start animated tween
        if (scaleRoutine != null) StopCoroutine(scaleRoutine);
        scaleRoutine = StartCoroutine(AnimateScaleTo(targetScale));
    }

    System.Collections.IEnumerator AnimateScaleTo(Vector3 targetScale)
    {
        Vector3 start = T.localScale;
        float elapsed = 0f;

        while (elapsed < scaleDuration)
        {
            if (T == null) yield break; // Safety if target got destroyed
            elapsed += Time.deltaTime;
            float t = Mathf.Clamp01(elapsed / Mathf.Max(0.0001f, scaleDuration));
            float e = ease != null ? ease.Evaluate(t) : t;
            T.localScale = Vector3.LerpUnclamped(start, targetScale, e);
            yield return null;
        }

        if (T != null) T.localScale = targetScale;
        scaleRoutine = null;
    }
}
