using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationManager : MonoBehaviour
{
    [SerializeField] Animator explainAnim;
    public void ShowExplanation()
    {
        explainAnim.SetBool("exp", !explainAnim.GetBool("exp"));
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
