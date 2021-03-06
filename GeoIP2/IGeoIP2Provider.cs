﻿using MaxMind.GeoIP2.Responses;

namespace MaxMind.GeoIP2
{
    /// <summary>
    /// This class provides the interface implemented by both <see cref="DatabaseReader"/>
    /// and <see cref="WebServiceClient"/>.
    /// </summary>
    public interface IGeoIP2Provider
    {
        /// <summary>
        /// Returns an <see cref="OmniResponse"/> for the specified ip address.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>An <see cref="OmniResponse"/></returns>
        OmniResponse Omni(string ipAddress);

        /// <summary>
        /// Returns an <see cref="CountryResponse"/> for the specified ip address.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>An <see cref="CountryResponse"/></returns>
        CountryResponse Country(string ipAddress);

        /// <summary>
        /// Returns an <see cref="CityResponse"/> for the specified ip address.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>An <see cref="CityResponse"/></returns>
        CityResponse City(string ipAddress);

        /// <summary>
        /// Returns an <see cref="CityIspOrgResponse"/> for the specified ip address.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>An <see cref="CityIspOrgResponse"/></returns>
        CityIspOrgResponse CityIspOrg(string ipAddress);
    }
}