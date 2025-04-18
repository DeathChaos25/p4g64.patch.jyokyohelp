using p4g64.patch.jyokyohelp.Configuration;
using Reloaded.Memory.SigScan.ReloadedII.Interfaces;
using Reloaded.Memory;
using Reloaded.Mod.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reloaded.Memory.Interfaces;

namespace p4g64.patch.jyokyohelp
{
    internal unsafe class Utils
    {
        private static ILogger _logger;
        private static Config _config;
        private static IStartupScanner _startupScanner;
        internal static nint BaseAddress { get; private set; }

        internal static bool Initialise(ILogger logger, Config config, IModLoader modLoader)
        {
            _logger = logger;
            _config = config;
            using var thisProcess = Process.GetCurrentProcess();
            BaseAddress = thisProcess.MainModule!.BaseAddress;

            var startupScannerController = modLoader.GetController<IStartupScanner>();
            if (startupScannerController == null || !startupScannerController.TryGetTarget(out _startupScanner))
            {
                LogError($"Unable to get controller for Reloaded SigScan Library");
                return false;
            }

            return true;
        }

        internal static void Log(string message)
        {
            _logger.WriteLineAsync($"[Custom In-Combat Skill Effect Text] {message}");
        }

        internal static void LogDebug(string message)
        {
            if(_config.Debug) _logger.WriteLineAsync($"[Custom In-Combat Skill Effect Text] {message}");
        }

        internal static void LogWarning(string message)
        {
            _logger.WriteLineAsync($"[Custom In-Combat Skill Effect Text] {message}", System.Drawing.Color.Yellow);
        }

        internal static void LogError(string message)
        {
            _logger.WriteLineAsync($"[Custom In-Combat Skill Effect Text] {message}", System.Drawing.Color.Red);
        }

        internal static void SigScan(string pattern, string name, Action<nint> action)
        {
            if (pattern != null)
            {
                _startupScanner.AddMainModuleScan(pattern, result =>
                {
                    if (!result.Found)
                    {
                        LogError($"Unable to find signature for {name}");
                        return;
                    }

                    action(result.Offset + BaseAddress);
                });
            }
            else
            {
                LogWarning($"{name} not used in this game");
            }
        }

        internal static Dictionary<TKey, TValue> DeserializeFile<TKey, TValue>(string filePath)
        where TKey : notnull
        {
            var lines = File.ReadAllLines(filePath);
            var result = new Dictionary<TKey, TValue>();
            foreach (var line in lines)
            {
                if (line.StartsWith("//"))
                    continue;

                var parts = line.Split("|", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                    continue;

                var key = GetValue<TKey>(parts[0])!;
                var valueObj = GetValue<TValue>(parts[1])!;
                result[key] = valueObj;
            }

            return result;
        }

        private static TValue? GetValue<TValue>(string valueInput) => (TValue)Convert.ChangeType(valueInput, typeof(TValue));

        /// <summary>
        /// Gets the address of a global from something that references it
        /// </summary>
        /// <param name="ptrAddress">The address to the pointer to the global (like in a mov instruction or something)</param>
        /// <returns>The address of the global</returns>
        internal static unsafe nuint GetGlobalAddress(nint ptrAddress)
        {
            return (nuint)((*(int*)ptrAddress) + ptrAddress + 4);
        }

        internal static void PatchAddress(nuint adr)
        {
            var memory = Memory.Instance;
            byte[] bytes = new byte[] { 0x25, 0x73, 0x00, 0x00 };
            memory.SafeWrite(adr, bytes);
        }
    }
}
