namespace Core.Models.Dtos.SignalR
{
    public class ConnectionMapping
    {
        private readonly Dictionary<string, HashSet<string>> _connections = new();

        public void Add(string userId, string connectionId)
        {
            lock (_connections)
            {
                if (!_connections.TryGetValue(userId, out var connections))
                {
                    connections = new HashSet<string>();
                    _connections.Add(userId, connections);
                }

                lock (connections)
                {
                    connections.Add(connectionId);
                }
            }
        }

        public void Remove(string userId, string connectionId)
        {
            lock (_connections)
            {
                if (!_connections.TryGetValue(userId, out var connections))
                {
                    return;
                }

                lock (connections)
                {
                    connections.Remove(connectionId);

                    if (connections.Count == 0)
                    {
                        _connections.Remove(userId);
                    }
                }
            }
        }

        public void RemoveConnection(string connectionId)
        {
            lock (_connections)
            {
                var targetConnections = _connections
                    .Where(e => e.Value.Any(h => h == connectionId))
                    .ToList();


                lock (targetConnections)
                {
                    targetConnections.ForEach(e => e.Value.Remove(connectionId));
                }
            }
        }
    }
}
