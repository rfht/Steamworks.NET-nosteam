// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2019 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	[System.Serializable]
	public struct RTime32 : System.IEquatable<RTime32>, System.IComparable<RTime32> {
		public uint m_RTime32;
		public RTime32(uint value) { m_RTime32 = value; }
		public override string ToString() { return m_RTime32.ToString(); }
		public override bool Equals(object other) {
			return other is RTime32 && this == (RTime32)other;
		}
		public override int GetHashCode() { return m_RTime32.GetHashCode(); }
		public static bool operator ==(RTime32 x, RTime32 y) {
			return x.m_RTime32 == y.m_RTime32;
		}
		public static bool operator !=(RTime32 x, RTime32 y) { return !(x == y); }
		public static explicit operator RTime32(uint value) { return new RTime32(value); }
		public static explicit operator uint(RTime32 that) { return that.m_RTime32; }
		public bool Equals(RTime32 other) { return m_RTime32 == other.m_RTime32; }
		public int CompareTo(RTime32 other) {
			return m_RTime32.CompareTo(other.m_RTime32);
		}
	}
}
