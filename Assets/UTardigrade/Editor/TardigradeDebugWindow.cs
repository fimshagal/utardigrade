using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UTardigrade.Runtime;

namespace UTardigrade.Editor
{
    public class TardigradeDebugWindow : EditorWindow
    {
        private Vector2 _scroll;

        [MenuItem("Window/Tardigrade/Debugger")]
        
        public static void Open()
        {
            GetWindow<TardigradeDebugWindow>("Tardigrade Debugger");
        }

        private void OnEditorUpdate()
        {
            Repaint();
        }

        private void OnEnable()
        {
            EditorApplication.update += OnEditorUpdate;
        }
        
        private void OnDisable()
        {
            EditorApplication.update -= OnEditorUpdate;
        }

        private void OnGUI()
        {
            GUILayout.Space(6);
            GUILayout.Label("Stores", EditorStyles. boldLabel);

            var storeAgents = TardigradeDebugRegistry.StoreAgents;

            if (storeAgents == null || storeAgents.Count == 0)
            {
                EditorGUILayout.HelpBox("No stores registered or runtime isn't running. Add \"TardigradeStoreAgent\" components to GameObjects and check it in runtime", MessageType.Info);
                return;
            }

            using (new EditorGUILayout.HorizontalScope())
            {
                GUILayout.Label($"Count: {storeAgents.Count}");
                GUILayout.FlexibleSpace();

                if (GUILayout.Button("Refresh", GUILayout.Width(80)))
                {
                    Repaint();
                }
            }
            
            GUILayout.Space(6);

            _scroll = EditorGUILayout.BeginScrollView(_scroll);

            foreach (var keyValue in storeAgents)
            {
                EditorGUILayout.LabelField($"- {keyValue.Value.storeName}");
            }
            
            EditorGUILayout.EndScrollView();
        }
    }
}