using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParticleScale : MonoBehaviour
{
    private List<float> initialSizes = new List<float>();
    private Vector3 transformScale;
    [SerializeField, SetProperty("ScaleSize")]
    private float scaleSize = 1f;
    public float ScaleSize
    {
        get
        {
            return scaleSize;
        }
        set
        {
            scaleSize = value;
            UpdateScale();
        }
    }
    void Awake()
    {
        Initialize();
    }

    void Start()
    {
        UpdateScale();
    }

    bool hasInit = false;
    private void Initialize()
    {
        if (!Application.isPlaying)
        {
            return;
        }

        if (hasInit)
        {
            return;
        }

        // Save off all the initial scale values at start.
        transformScale = transform.localScale;

        ParticleSystem[] particles = gameObject.GetComponentsInChildren<ParticleSystem>();
        for(int i = 0; i < particles.Length;i++)
        {
            initialSizes.Add(particles[i].main.startSizeMultiplier);
            initialSizes.Add(particles[i].main.startSpeedMultiplier);
            //initialSizes.Add(particle.startRotation);
            //initialSizes.Add(particle.gravityModifier);
            ParticleSystemRenderer renderer = particles[i].GetComponent<ParticleSystemRenderer>();
            if (renderer)
            {
                initialSizes.Add(renderer.lengthScale);
                initialSizes.Add(renderer.velocityScale);
            }
        }

        hasInit = true;
    }

    private void UpdateScale()
    {
        if (!Application.isPlaying)
        {
            return;
        }

        Initialize();
        
        gameObject.transform.localScale = Vector3.Scale(transformScale, new Vector3(ScaleSize, ScaleSize, ScaleSize));

        // Scale all the particle components based on parent.
        int arrayIndex = 0;
        ParticleSystem[] particles = gameObject.GetComponentsInChildren<ParticleSystem>();
        for(int i = 0; i < particles.Length ;i++)
        {
            ParticleSystem.MainModule particleMain = particles[i].main;
            particleMain.startSizeMultiplier = initialSizes[arrayIndex++] * ScaleSize;
            particleMain.startSpeedMultiplier = initialSizes[arrayIndex++] / ScaleSize;
            //particle.startRotation = initialSizes[arrayIndex++] * ScaleSize;
            //particle.gravityModifier = initialSizes[arrayIndex++] * ScaleSize;
            ParticleSystemRenderer renderer = particles[i].GetComponent<ParticleSystemRenderer>();
            if (renderer)
            {
                renderer.lengthScale = initialSizes[arrayIndex++] * ScaleSize;
                renderer.velocityScale = initialSizes[arrayIndex++] * ScaleSize;
            }
        }
    }
}