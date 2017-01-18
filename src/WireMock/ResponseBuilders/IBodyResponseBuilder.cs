﻿namespace WireMock.ResponseBuilders
{
    /// <summary>
    /// The BodyResponseBuilder interface.
    /// </summary>
    public interface IBodyResponseBuilder : IDelayResponseBuilder
    {
        /// <summary>
        /// The with body.
        /// </summary>
        /// <param name="body">
        /// The body.
        /// </param>
        /// <returns>
        /// The <see cref="IResponseBuilder"/>.
        /// </returns>
        IResponseBuilder WithBody(string body);
    }
}