using UnityEngine;
using DG.Tweening;

public class Bus : Transport
{
    public override void Travel()
    {
        Animate();
    }

    private void Animate()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(transform.position.x - 60, 2f));
        sequence.Append(transform.DORotate(new Vector3(0, 180, 0), 0.5f));
        sequence.Append(transform.DOMoveZ(transform.position.z - 100, 1.5f));
        sequence.Play();

    }
}
