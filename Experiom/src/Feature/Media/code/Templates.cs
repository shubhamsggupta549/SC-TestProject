using System.Runtime.InteropServices;
using Sitecore.Data;

public static class Templates
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Image
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct Fields
		{
			public static ID Image { get; } = new ID("{EBE4FDEF-16D5-4D19-833C-24A241628A3A}");


			public static ID TargetUrl { get; } = new ID("{54CAB1BA-53D3-4CE4-AB7E-F8C17596AA47}");


			public static ID ImageCaption { get; } = new ID("{4F52B258-7B05-4D6C-8C96-2E2EAC46DC1B}");

		}

		public static readonly ID ID = ID.Parse("{BB8A85AB-1F6D-4518-8772-1C9F4F8DAC18}");
	}
}