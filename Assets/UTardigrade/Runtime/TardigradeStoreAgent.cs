using System;
using UnityEngine;
using TardigradeStore;

namespace UTardigrade.Runtime
{
    [DisallowMultipleComponent]
    [ExecuteAlways]
    public class TardigradeStoreAgent : MonoBehaviour
    {
        [Tooltip("Tardigrade Store Agent")] 
    
        [SerializeField] public string storeName = "AnonymousTardigrade";

        public string Id => _id;
        public Store Store => _store;

        private string _id;
        private Store _store;
        private void Awake()
        {
            _id = Guid.NewGuid().ToString();
            _store = new Store();
            
#if UNITY_EDITOR
            TardigradeDebugRegistry.RegisterStoreAgent(this);
#endif
        }

        private void OnDestroy()
        {
#if UNITY_EDITOR
            TardigradeDebugRegistry.UnRegisterStoreAgent(Id);
#endif    
        }
    }   
}
