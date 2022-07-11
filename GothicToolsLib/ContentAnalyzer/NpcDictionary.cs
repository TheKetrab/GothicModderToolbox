using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GothicToolsLib.Models;

namespace GothicToolsLib.ContentAnalyzer
{
    public class NpcDictionary : IEnumerable<NpcModel>
    {
        private readonly Dictionary<int,NpcModel> _map; // <id,npc>
        private object _mapLock = new object();

        public NpcDictionary()
        {
            _map = new Dictionary<int, NpcModel>
            {
                { -1, new NpcModel(-1,"Unknown") },
                { 0, new NpcModel(0, "Will") },
            };
        }

        public NpcModel this[int key]
        {
            get => _map[key];
            set => _map[key] = value;
        }

        public void AddLine(int id, AIOutputModel aio, string name="")
        {
            lock (_mapLock)
            {
                if (_map.ContainsKey(id))
                {
                    _map[id].Dialogs.Add(aio);
                }
                else
                {
                    NpcModel npc = new NpcModel(id, name);
                    _map.Add(id, npc);
                    _map[id].Dialogs.Add(aio);
                }
            }
        }

        public int GetIdByName(string name)
        {
            foreach (var kv in _map)
            {
                if (string.Equals(kv.Value.Name, name, StringComparison.CurrentCultureIgnoreCase))
                    return kv.Key;
            }

            return -1;
        }

        public IEnumerator<NpcModel> GetEnumerator()
        {
            foreach (NpcModel npc in _map.Values)
            {
                yield return npc;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
