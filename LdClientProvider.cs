using LaunchDarkly.Sdk;
using LaunchDarkly.Sdk.Server;
using System;

namespace FeatureFlagPOC_LD
{
    public static class LdClientProvider
    {
        // Create a single static instance for the lifetime of the app.
        private static LdClient _client;

        public static LdClient Client
        {
            get
            {
                if (_client == null)
                {
                    // Initialize the LaunchDarkly client with your SDK key.
                    // Use a sensible timeout for initialization.
                    _client = new LdClient("enter your sdk key");
                }
                return _client;
            }
        }

        // Optional: Clean up the client when the application shuts down.
        public static void Shutdown() => _client?.Dispose();
    }
}
