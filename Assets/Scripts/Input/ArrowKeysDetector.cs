using Assets.Scripts;
using UnityEngine;

public class ArrowKeysDetector : MonoBehaviour, IInputDetector
{
    public InputDirection? DetectInputDirection()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            return InputDirection.Top;
        else if (Input.GetKey(KeyCode.LeftArrow))
            return InputDirection.Left;
        else if (Input.GetKey(KeyCode.RightArrow))
            return InputDirection.Right;
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            return InputDirection.Bottom;
        else
            return null;
    }
}