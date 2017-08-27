using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Active and named net drivers instantiated from an FNetDriverDefinition
	/// The net driver will remain instantiated on this struct until it is destroyed
	/// </summary>
	public partial struct FNamedNetDriver
	{
		
		#region DLLInmport
		#endregion
		
		#region Property
		
		/// <summary>
		/// Definition associated with this net driver
		/// </summary>
		public FNetDriverDefinition NetDriverDef { get; set; } 
		#endregion
		
		#region ExternMethods
		#endregion
		
	}}
