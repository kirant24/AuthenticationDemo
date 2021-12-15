using System;

namespace AuthenticationDemo
{
    public interface IJwtAuthenticationManager
    {
        /// <summary>
        /// Authenticate the user.
        /// </summary>
        /// <param name="name">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>Json Web Token String.</returns>
        string Authenticate(string name, string password);
    }
}
