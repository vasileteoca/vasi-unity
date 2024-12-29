using System.Collections;
using UnityEngine;

public class VasiAnimationPlayer : MonoBehaviour
{
    private VasiAnimation animation;
    private bool isPlaying;

    public void Initialize(VasiAnimation animation)
    {
        this.animation = animation;
    }

    public void Play()
    {
        if (animation != null)
        {
            isPlaying = true;
            StartCoroutine(PlayAnimation());
        }
    }

    public void Stop()
    {
        isPlaying = false;
    }

    private IEnumerator PlayAnimation()
    {
        animation.PlayAnimation();
        while (isPlaying)
        {
            yield return null;
        }
    }

    private void Update()
    {
        if (isPlaying)
        {
            // Update logic for the current frame display can be added here
        }
    }
}