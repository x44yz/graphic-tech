using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class DamageFlash : MonoBehaviour
{
    [ColorUsage(true, true)]
    public Color flashColor;
    public float flashTime;

    private SpriteRenderer spriteRenderer;
    private Material material;

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        material = spriteRenderer.material;
    }

    private IEnumerator StartFlash()
    {
        SetFlashColor();

        float flashAmount = 0f;
        float elapsedTime = 0f;
        while (elapsedTime < flashTime)
        {
            elapsedTime += Time.deltaTime;
            flashAmount = Mathf.Lerp(1f, 0f, (elapsedTime / flashTime));
            SetFlashAmount(flashAmount);
            yield return null;
        }
    }

    private void SetFlashColor()
    {
        material.SetColor("_FlashColor", flashColor);
    }

    private void SetFlashAmount(float amount)
    {
        material.SetFloat("_FlashAmount", amount);
    }

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private void TestFlash()
    {
        StartCoroutine(StartFlash());
    }
}
