using UnityEngine;
using System.Collections;

public class GoalScoring : MonoBehaviour
{
    public Highlighter highlighter;

    void OnTriggerEnter(Collider other)
    {
        print("Goal!");
        if (highlighter)
        {
            highlighter.Highlight();
        }
    }
}