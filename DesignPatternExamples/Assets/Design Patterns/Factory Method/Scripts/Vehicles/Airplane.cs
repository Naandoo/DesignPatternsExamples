using DG.Tweening;
using UnityEngine;
public class Airplane : Transport, IAirplane
{
    public override void Travel()
    {
        Animate();
    }

    private void Animate()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(transform.position.x - 500, 10f));
        sequence.Join(transform.DOMoveY(transform.position.y + 20, 10f));
        sequence.Play();
    }
}
