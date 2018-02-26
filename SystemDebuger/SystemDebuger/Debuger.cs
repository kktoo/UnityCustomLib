using UnityEngine;

namespace SystemDebuger
{
    public class Debuger
    {
        public static bool debugEnable = false;

        public static void Log(object message)
        {
            Log(message, null);
        }
        public static void Log(object message, UnityEngine.Object context)
        {
            if (debugEnable)
            {
                Debug.Log(message, context);
            }
        }

        public static void LogWarning(object message)
        {
            LogWarning(message, null);
        }
        public static void LogWarning(object message, UnityEngine.Object context)
        {
            if (debugEnable)
            {
                Debug.LogWarning(message, context);
            }
        }

        public static void LogError(object message)
        {
            LogError(message, null);
        }
        public static void LogError(object message, UnityEngine.Object context)
        {
            if (debugEnable)
            {
                Debug.LogError(message, context);
            }
        }
    }
}
