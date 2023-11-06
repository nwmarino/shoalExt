using BepInEx;

namespace shoalExt
{
    [BepInPlugin("com.nwmarino.shoalExt", "shoalExt", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new InitAllExfiltrationPointsPatch().Enable();
            new ScavExfiltrationPointPatch().Enable();

            Logger.LogInfo($"shoalExt has successfully patched.");
        }
    }
}
