using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator explainAnim;
    public void ShowExplanation()
    {
        explainAnim.SetBool("exp", !explainAnim.GetBool("exp"));
    }
}
