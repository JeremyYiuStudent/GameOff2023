using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Custom Asset/Dialogue")]
public class Dialogue : ScriptableObject
{
    public DialogueLine[] lines;
    [Serializable]
    public struct DialogueLine{
        public string text;
        public string speaker;
    }
}
