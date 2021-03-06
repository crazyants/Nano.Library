﻿using Nano.Web.Api.Requests.Interfaces;

namespace Nano.Web.Api.Requests
{
    /// <summary>
    /// Base Request Post.
    /// </summary>
    public abstract class BaseRequestPost : BaseRequest, IRequestPost
    {
        /// <inheritdoc />
        public abstract object GetBody();
    }
}