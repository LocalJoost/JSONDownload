using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using TMPro;

public class DeserializeJson : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _text;

    void Start()
    {
        var jsonstring = @"
{
   ""Property1"" : ""Hello"",
   ""Property2"" : ""Folks""
}";
        var deserializedObject = JsonConvert.DeserializeObject<DemoJson>(jsonstring);

        _text.text = string.Concat(deserializedObject.Property1,
            Environment.NewLine, deserializedObject.Property2);
    }
}
