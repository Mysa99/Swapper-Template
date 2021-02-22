using System;
using System.Runtime.InteropServices;

namespace Moon_Swapper
{
	// Token: 0x02000002 RID: 2
	public class DiscordRpc
	{
		// Token: 0x06000003 RID: 3
		[DllImport("DiscordRPC", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06000004 RID: 4
		[DllImport("DiscordRPC", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]
		public static extern void UpdatePresence(ref DiscordRpc.RichPresence presence);

		// Token: 0x06000005 RID: 5
		[DllImport("DiscordRPC", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
		public static extern void RunCallbacks();

		// Token: 0x06000006 RID: 6
		[DllImport("DiscordRPC", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
		public static extern void Shutdown();

		// Token: 0x04000001 RID: 1
		public const string DLL = "DiscordRPC";

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000009 RID: 9
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ReadyCallback();

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000D RID: 13
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void DisconnectedCallback(int errorCode, string message);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000011 RID: 17
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void ErrorCallback(int errorCode, string message);

		// Token: 0x02000006 RID: 6
		public struct EventHandlers
		{
			// Token: 0x04000002 RID: 2
			public DiscordRpc.ReadyCallback readyCallback;

			// Token: 0x04000003 RID: 3
			public DiscordRpc.DisconnectedCallback disconnectedCallback;

			// Token: 0x04000004 RID: 4
			public DiscordRpc.ErrorCallback errorCallback;
		}

		// Token: 0x02000007 RID: 7
		[Serializable]
		public struct RichPresence
		{
			// Token: 0x04000005 RID: 5
			public string state;

			// Token: 0x04000006 RID: 6
			public string details;

			// Token: 0x04000007 RID: 7
			public long startTimestamp;

			// Token: 0x04000008 RID: 8
			public long endTimestamp;

			// Token: 0x04000009 RID: 9
			public string largeImageKey;

			// Token: 0x0400000A RID: 10
			public string largeImageText;

			// Token: 0x0400000B RID: 11
			public string smallImageKey;

			// Token: 0x0400000C RID: 12
			public string smallImageText;

			// Token: 0x0400000D RID: 13
			public string partyId;

			// Token: 0x0400000E RID: 14
			public int partySize;

			// Token: 0x0400000F RID: 15
			public int partyMax;

			// Token: 0x04000010 RID: 16
			public string matchSecret;

			// Token: 0x04000011 RID: 17
			public string joinSecret;

			// Token: 0x04000012 RID: 18
			public string spectateSecret;

			// Token: 0x04000013 RID: 19
			public bool instance;
		}
	}
}
