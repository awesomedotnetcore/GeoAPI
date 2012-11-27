// Portions copyright 2005 - 2006: Morten Nielsen (www.iter.dk)
// Portions copyright 2006 - 2008: Rory Plaire (codekaizen@gmail.com)
//
// This file is part of GeoAPI.Net.
// GeoAPI.Net is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// GeoAPI.Net is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with GeoAPI.Net; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

using System;

namespace GeoAPI.CoordinateSystems
{
	/// <summary>
	/// The IPrimeMeridian interface defines the standard information stored with prime
	/// meridian objects. Any prime meridian object must implement this interface as
	/// well as the ISpatialReferenceInfo interface.
	/// </summary>
	public interface IPrimeMeridian : IInfo
	{
		/// <summary>
		/// Gets or sets the longitude of the prime meridian (relative to the Greenwich prime meridian).
		/// </summary>
		Double Longitude { get; }

		/// <summary>
		/// Gets or sets the AngularUnits.
		/// </summary>
		IAngularUnit AngularUnit { get; }
	}
}