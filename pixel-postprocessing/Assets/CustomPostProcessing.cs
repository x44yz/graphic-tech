using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CustomPostProcessing : MonoBehaviour
{
    public Material mat;

    // [ImageEffectOpaque]
    private void OnRenderImage(RenderTexture src, RenderTexture dest) 
    {
        Graphics.Blit(src, dest, mat);
    }
}
