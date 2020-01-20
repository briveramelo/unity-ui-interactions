﻿using BRM.EventRecorder.UnityEvents;
using UnityEditor;
using UnityEngine;

namespace BRM.EventRecorder.UnityEditor
{
    public class UnityEventRecorderWindow : RecorderWindow
    {
        [MenuItem("/" + Constants.PackageDeveloper + "/" + Constants.DisplayedAppName + ": Unity Events")]
        private static void ShowWindow()
        {
            var window = GetWindow<UnityEventRecorderWindow>("Unity Events");
            window.minSize = Vector2.one * 300;
            window.Show();
        }
        
        protected override RecordingService _recordingService => _recordingServiceLocal ?? (_recordingServiceLocal = new UnityRecordingServiceFactory().Create());
    }
}