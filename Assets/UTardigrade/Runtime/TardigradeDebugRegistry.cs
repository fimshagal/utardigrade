using System.Collections.Generic;
using TardigradeStore;

namespace UTardigrade.Runtime
{
    public static class TardigradeDebugRegistry
    {
        private static readonly Dictionary<string, TardigradeStoreAgent> _storesAgents = new ();

        public static Dictionary<string, TardigradeStoreAgent> StoreAgents => _storesAgents;

        public static void RegisterStoreAgent(TardigradeStoreAgent storeAgent)
        {
            if (storeAgent == null)
            {
                return;
            }

            _storesAgents[storeAgent.Id] = storeAgent;
        }
        
        public static void UnRegisterStoreAgent(string id)
        {
            if (!_storesAgents.ContainsKey(id))
            {
                return;
            }

            _storesAgents.Remove(id);
        }
    }
}