using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class dialogs
{
    [SerializeField] List<string> lines;
    public List<string> Lines
    {
        get { return lines; }
    }
}
